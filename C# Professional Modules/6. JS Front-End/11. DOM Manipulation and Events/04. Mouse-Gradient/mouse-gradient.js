function attachGradientEvents() {
    let resultEl = document.querySelector('#result');
    let gradientEl = document.querySelector('#gradient');

    gradientEl.addEventListener('mousemove', e => {
        let currentPs = e.offsetX;
        let elementWidth = e.currentTarget.clientWidth;

        let percent = Math.floor((currentPs / elementWidth) * 100);

        resultEl.textContent = percent + '%'
    });
}
