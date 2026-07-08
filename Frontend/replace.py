import re
path = r'c:\Users\Grachelle Mae\enrollment-system\Frontend\enrollment.html'
with open(path, 'r', encoding='utf-8') as f:
    content = f.read()

# Replace quotes around 'http://localhost:5024/...' with backticks and variables
content = re.sub(r"'http://localhost:5024([^']*)'", r'`${window.API_BASE_URL}\1`', content)
# Replace existing backticks containing http://localhost:5024
content = re.sub(r'`http://localhost:5024([^`]*)`', r'`${window.API_BASE_URL}\1`', content)

# Also insert <script src="config.js"></script> in <head>
content = content.replace('<script src="https://cdn.tailwindcss.com"></script>', '<script src="https://cdn.tailwindcss.com"></script>\n    <script src="config.js"></script>')

with open(path, 'w', encoding='utf-8') as f:
    f.write(content)
print('Done!')
