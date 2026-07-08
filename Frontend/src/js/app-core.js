document.addEventListener('DOMContentLoaded', () => {
    // 1. Get user info from localStorage (fallback to Student if missing)
    const userRole = localStorage.getItem('userRole') || 'Student';
    const userName = localStorage.getItem('userName') || 'John Doe';
    const userAvatar = localStorage.getItem('userAvatar') || 'JD';

    const isAdmin = userRole === 'Admin';

    // 2. Update Sidebar Profile Information
    const sidebarRoleElems = document.querySelectorAll('.sidebar-text p');
    if (sidebarRoleElems.length >= 2) {
        sidebarRoleElems[0].textContent = userName;
        sidebarRoleElems[1].textContent = isAdmin ? 'Registrar' : 'Student';
    }

    const avatarElem = document.querySelector('.profile-block .w-10');
    if (avatarElem) {
        avatarElem.textContent = userAvatar;
    }

    // 3. Dynamic UI Toggling based on data-role
    // Elements with data-role="admin" will ONLY show for Admins
    // Elements with data-role="student" will ONLY show for Students
    const roleElements = document.querySelectorAll('[data-role]');
    roleElements.forEach(elem => {
        const requiredRole = elem.getAttribute('data-role');
        if (requiredRole === 'admin' && !isAdmin) {
            elem.style.display = 'none';
        } else if (requiredRole === 'student' && isAdmin) {
            elem.style.display = 'none';
        } else {
            // Remove inline display none if it was set (or leave it to CSS)
            elem.style.display = '';
        }
    });

    // 4. Update Navigation Links in Sidebar
    // Ensures all links point to the unified pages instead of student-*/admin-*
    const navLinks = document.querySelectorAll('aside a.nav-item');
    navLinks.forEach(link => {
        let href = link.getAttribute('href');
        if (href) {
            href = href.replace('student-', '').replace('admin-', '');
            link.setAttribute('href', href);
        }
    });

    // 5. Custom Logout Confirmation Modal
    const logoutLinks = Array.from(document.querySelectorAll('a.nav-item')).filter(link => 
        link.textContent.includes('Logout') || link.getAttribute('href') === 'login.html'
    );

    logoutLinks.forEach(link => {
        link.addEventListener('click', (e) => {
            e.preventDefault();

            // Create modal container
            const modalOverlay = document.createElement('div');
            modalOverlay.className = 'fixed inset-0 z-[100] flex items-center justify-center bg-slate-900/40 backdrop-blur-sm opacity-0 transition-opacity duration-300';
            
            // Modal Card HTML
            modalOverlay.innerHTML = `
                <div class="bg-white rounded-2xl shadow-2xl border border-slate-100 p-6 w-full max-w-sm transform scale-95 transition-transform duration-300">
                    <div class="flex flex-col items-center text-center">
                        <div class="w-12 h-12 rounded-full bg-red-50 text-red-500 flex items-center justify-center mb-4">
                            <svg class="w-6 h-6" fill="none" viewBox="0 0 24 24" stroke="currentColor">
                                <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M17 16l4-4m0 0l-4-4m4 4H7m6 4v1a3 3 0 01-3 3H6a3 3 0 01-3-3V7a3 3 0 013-3h4a3 3 0 013 3v1" />
                            </svg>
                        </div>
                        <h3 class="text-xl font-bold text-slate-800 mb-2">Are you sure you want to logout?</h3>
                        <p class="text-slate-500 text-sm mb-6 px-4">You will need to sign back in to access your dashboard and applications.</p>
                        
                        <div class="flex gap-3 w-full">
                            <button id="cancelLogoutBtn" class="flex-1 py-2.5 rounded-xl border border-slate-200 text-slate-600 font-semibold hover:bg-slate-50 transition-colors">
                                Cancel
                            </button>
                            <button id="confirmLogoutBtn" class="flex-1 py-2.5 rounded-xl bg-red-500 text-white font-semibold shadow-lg shadow-red-500/30 hover:bg-red-600 transition-colors">
                                Log Out
                            </button>
                        </div>
                    </div>
                </div>
            `;

            document.body.appendChild(modalOverlay);

            // Animate in
            requestAnimationFrame(() => {
                modalOverlay.classList.remove('opacity-0');
                modalOverlay.querySelector('div').classList.remove('scale-95');
                modalOverlay.querySelector('div').classList.add('scale-100');
            });

            // Handle actions
            const closeModal = () => {
                modalOverlay.classList.add('opacity-0');
                modalOverlay.querySelector('div').classList.add('scale-95');
                modalOverlay.querySelector('div').classList.remove('scale-100');
                setTimeout(() => modalOverlay.remove(), 300);
            };

            document.getElementById('cancelLogoutBtn').addEventListener('click', closeModal);
            modalOverlay.addEventListener('click', (e) => {
                if(e.target === modalOverlay) closeModal();
            });

            document.getElementById('confirmLogoutBtn').addEventListener('click', () => {
                // Clear localStorage and redirect
                localStorage.clear();
                window.location.href = 'login.html';
            });
        });
    });

});
