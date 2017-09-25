function calculate() {
    let firstNumber = document.getElementById('firstNumber').value;
    let secondNumber = document.getElementById('secondNumber').value;
    firstNumber = Number(firstNumber);
    secondNumber = Number(secondNumber);

    document.getElementById('result').innerHTML =
        firstNumber + secondNumber;
}