// Configuration
const API_BASE_URL = 'http://localhost:5024';

document.addEventListener('DOMContentLoaded', () => {
    // Add smooth scrolling for anchor links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            e.preventDefault();
            document.querySelector(this.getAttribute('href')).scrollIntoView({
                behavior: 'smooth'
            });
        });
    });

    // Handle 'Enroll Now' click
    const enrollBtn = document.getElementById('enrollNowBtn');
    if (enrollBtn) {
        enrollBtn.addEventListener('click', () => {
            // In a real app, this would open a modal or redirect to the enrollment form
            enrollBtn.innerHTML = 'Connecting... <span class="btn-arrow">⚡</span>';
            
            // Example of how to call the .NET API
            checkApiHealth();
        });
    }

    // Add parallax effect to orbs
    document.addEventListener('mousemove', (e) => {
        const orbs = document.querySelectorAll('.glow-orb');
        const x = e.clientX / window.innerWidth;
        const y = e.clientY / window.innerHeight;

        orbs.forEach((orb, index) => {
            const speed = (index + 1) * 20;
            orb.style.transform = `translate(${x * speed}px, ${y * speed}px)`;
        });
    });
});

// Example function to test API connection
async function checkApiHealth() {
    try {
        const response = await fetch(`${API_BASE_URL}/weatherforecast`);
        if (response.ok) {
            const data = await response.json();
            console.log('API is online!', data);
            
            // Revert button
            const enrollBtn = document.getElementById('enrollNowBtn');
            enrollBtn.innerHTML = 'System Online! <span class="btn-arrow">✓</span>';
            enrollBtn.style.background = 'linear-gradient(135deg, #10b981 0%, #059669 100%)';
            
            setTimeout(() => {
                alert("Connected successfully to the .NET API!");
            }, 500);
        } else {
            throw new Error('API returned an error');
        }
    } catch (error) {
        console.error('API connection failed:', error);
        alert('Could not connect to the API. Is your .NET backend running?');
        const enrollBtn = document.getElementById('enrollNowBtn');
        enrollBtn.innerHTML = 'Enroll Now <span class="btn-arrow">→</span>';
    }
}
