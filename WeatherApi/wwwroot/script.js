document.getElementById('weatherForm').addEventListener('submit', async function (e) {
    e.preventDefault();

    const cities = document.getElementById('cities').value;
    const startDate = document.getElementById('startDate').value;
    const endDate = document.getElementById('endDate').value;

    const response = await fetch(`/api/weather?cities=${cities}&startDate=${startDate}&endDate=${endDate}`);
    const result = await response.json();

    document.getElementById('resultContent').textContent = JSON.stringify(result, null, 2);
});
