$(document).ready(function () {
    console.log("ready!");
    var ctx = document.getElementById('myChart');
    var myChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: ["08:00", "10:00", "12:00", "14:00", "16:00", "18:00", "20:00", "22:00", "00:00", "02:00", "04:00", "06:00"],
            datasets: [{
                label: "Yêu một người gian dối",
                data: [5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60],
                backgroundColor: [
                    'rgba(255, 159, 64, 0.2)'
                ],
                borderColor: [
                    'rgba(255, 99, 132, 1)'
                ],
                borderWidth: 1
            },
            {
                label: "Sầu tương tư",
                data: [3, 7, 12, 22, 27, 30, 36, 41, 47, 53, 54, 57],
                backgroundColor: [
                    'rgba(255, 159, 64, 0.2)'
                ],
                borderColor: [
                    'rgba(153, 102, 255, 1)'
                ],
                borderWidth: 1
            },
            {
                label: "Anh thề đấy",
                data: [2, 5, 10, 20, 25, 27, 33, 37, 44, 50, 55],
                backgroundColor: [
                    'rgba(153, 102, 255, 0.2)'
                ],
                borderColor: [
                    'rgba(75, 192, 192, 1)'
                ],
                borderWidth: 1
            }
            ]

        },
        options: {
            responsive: true,
            plugins: {
                legend: {
                    position: 'top',
                },
            }
        }
    });
});

