// Minimal floating chatbot widget
document.addEventListener('DOMContentLoaded', function () {
    const widget = document.createElement('div');
    widget.id = 'chatbot-float';
    widget.innerHTML = `
        <img src="/images/chatbot-icon.svg" id="chatbot-icon" style="width:48px;cursor:pointer;position:fixed;bottom:32px;right:32px;z-index:1000;" alt="Chatbot" />
        <div id="chatbot-panel" style="display:none;position:fixed;bottom:90px;right:32px;width:320px;height:400px;background:#fff;border-radius:16px;box-shadow:0 4px 32px rgba(0,0,0,0.2);z-index:1001;overflow:hidden;">
            <div style="background:#6d28d9;color:#fff;padding:12px 16px;font-weight:bold;">AI4ALL Assistant <span id="chatbot-close" style="float:right;cursor:pointer;">&times;</span></div>
            <div id="chatbot-messages" style="padding:12px;height:300px;overflow-y:auto;font-size:1rem;"></div>
            <form id="chatbot-form" style="display:flex;padding:8px;">
                <input id="chatbot-input" type="text" style="flex:1;padding:8px;border-radius:8px;border:1px solid #ccc;" placeholder="Type your question..." autocomplete="off" />
                <button type="submit" style="margin-left:8px;background:#6d28d9;color:#fff;border:none;border-radius:8px;padding:8px 16px;">Send</button>
            </form>
        </div>
    `;
    document.body.appendChild(widget);

    const icon = document.getElementById('chatbot-icon');
    const panel = document.getElementById('chatbot-panel');
    const close = document.getElementById('chatbot-close');
    icon.onclick = () => panel.style.display = 'block';
    close.onclick = () => panel.style.display = 'none';

    // Simple local echo for demo; replace with AJAX to backend/chatbot API
    document.getElementById('chatbot-form').onsubmit = function (e) {
        e.preventDefault();
        const input = document.getElementById('chatbot-input');
        const messages = document.getElementById('chatbot-messages');
        const userMsg = input.value.trim();
        if (!userMsg) return;
        messages.innerHTML += `<div style="margin-bottom:8px;"><b>You:</b> ${userMsg}</div>`;
        input.value = '';
        // Simulate bot reply
        setTimeout(() => {
            messages.innerHTML += `<div style="margin-bottom:8px;"><b>Bot:</b> (This is a demo. Connect to Rasa or another backend for real answers.)</div>`;
            messages.scrollTop = messages.scrollHeight;
        }, 600);
        messages.scrollTop = messages.scrollHeight;
    };
});
