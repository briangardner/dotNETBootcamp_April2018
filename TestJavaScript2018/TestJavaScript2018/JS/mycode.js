function SayHi()
{
    // console.log("Hello World!");
    alert("Hello World!");

}

function factorial()
{
   // 1. Get Input 
    var Input = prompt("Please enter a number:");
   // 2. Find Factorial 
    var factResult = 1; 

    for (var i = 1; i <= Input; i++) {
        factResult = factResult * i;
    }

    //3. Output
    alert("Result =" + factResult);
}

function add()
{
//1. Input 
    var num1 = parseInt(document.getElementById("num1").value);
    var num2 = parseInt(document.getElementById("num2").value);

    //2.ADD 
    var result = num1 + num2;
    //3. Output 
    alert("Result = " + result);
    document.getElementById("num1").value = "";
    document.getElementById("num2").value = "";
}

function addNewTask()
{
    var taskName = document.getElementById("tname").value;
    var dueDate = document.getElementById("dueDate").value;

    // Find a <table> element with id="myTable":
    var table = document.getElementById("tasks");

    // Create an empty <tr> element and add it to after the header
    var row = table.insertRow(1);

    // Insert new cells (<td> elements) at the 1st and 2nd position of the "new" <tr> element:
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);

    // Add some text to the new cells:
    cell1.innerHTML = taskName;
    cell2.innerHTML = dueDate;

}
