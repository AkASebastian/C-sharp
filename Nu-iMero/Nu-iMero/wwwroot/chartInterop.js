window.createChart = (canvasId, config) => {
    var ctx = document.getElementById(canvasId).getContext('2d');
    new Chart(ctx, config);
};
