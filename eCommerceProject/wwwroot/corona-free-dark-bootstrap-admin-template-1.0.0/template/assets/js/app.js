window.addEventListener("load", (event) => {
  let calculate = document.getElementById("calculate");
  let selectFirst = document.querySelector(".select-box-first");
  let selectSecond = document.querySelector(".select-box-second");
  let inputValue = document.querySelector(".input-box");
  let result = document.getElementById("result");
  let warning = document.getElementById("warning");

  createSelectBox(selectFirst, selectSecond);

  calculate.addEventListener("click", function () {
    result.innerHTML = "";
    warning.innerHTML = "";

    if (inputValue.value <= 0 || inputValue.value === "") {
      warning.innerHTML = "Hatalı yada eksik değer girdiniz.";
      return;
    }

    currencyCalculate(
      result,
      selectFirst.value,
      selectSecond.value,
      inputValue.value
    );
  });
});

function createSelectBox(selectFirst, selectSecond) {
  currentList.forEach((element) => {
    selectFirst.innerHTML += `<option value="${element.code}">${element.code}</option>`;
    selectSecond.innerHTML += `<option value="${element.code}">${element.code}</option>`;
  });
}

function currencyCalculate(result, selectFirst, selectSecond, inputValue) {
  fetch(
    `https://v6.exchangerate-api.com/v6/4d8499beb40653c6d0ee099b/pair/${selectFirst}/${selectSecond}`
  )
    .then((response) => response.json())
    .then((data) => {
      if (data.result === "success") {
        let conversion_rate = data.conversion_rate;
        let calculate = conversion_rate * inputValue;
        result.innerHTML = `${inputValue} ${selectFirst} = ${calculate.toFixed(
          2
        )} ${selectSecond}`;
      }
    });
}
