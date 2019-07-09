console.log("Hello World!");

console.log(3 + '42');
console.log(3 + '4' + 2);
console.log(3 + 4 + 2);
console.log(3 * '42');
console.log([1,2,3] + [4,5,6]);

// Primitive types - string/number/boolean/undefined
console.log(typeof "asdf");
console.log(typeof 123);
console.log(typeof true);
console.log(typeof undefined);

// Complex types - function/object
console.log(typeof function() {});
console.log(typeof {});
console.log(typeof class {}); // Implemented with function
console.log(typeof [1,2]);

// Usage of backslash
console.log("\"");
console.log("\\");
console.log("C:\asdf\asdf\asdf\\");
console.log("C:\\asdf\\asdf\\asdf\\");

console.log("'''''''''\"asdf");
console.log('"""""""""\'asdf');

// w/o closure
let counter = 0;
function add() {
    counter ++;
}

// w/ closure
let addFun = function() {
    var counter = 0;
    return function () {
        counter += 1;
        return counter;
    }
}

let add1 = addFun;

// Equivalent to ...
let add2 = (function() {
    let counter = 0;
    return function () {
        counter += 1;
        return counter;
    }
})();

let abc = 0;
abc = 'string';
abc = false;
console.log(typeof abc);

// Array manipulation
let arr1 = [1,2,3];
let arr2 = [4,5,6];
let arr3 = arr1.concat(arr2);
console.log(arr3);
let arr4 = arr3.push(7);
console.log(arr4);
let arr5 = arr3.push([9,8]);
console.log(arr5);

console.log([255,255,255,255].join("."));

let testarr = [1];
console.log(testarr.pop());
console.log(testarr);
console.log(testarr.pop());

console.log(arr3.reverse());
console.log(arr3.reverse().sort());
console.log(arr3.slice(1,1+3));

console.log(typeof arr5);

// Trinocular operator / ternary operator
let a = 99;
console.log(a < 100 ? a : a + 1);

arr3.forEach(ele => console.log(ele)); // Equivalent to arr3.forEach(function(element) {console.log(element);})

// Lab1
let sum1 = 0;
for(let i = 6; i <= 66666; i ++) {
    if(i % 2 === 0 ) sum1 += i;
}
console.log(sum1);

// Lab2
let sum2 = 0;
for(let i = 1; i <= 9; i ++)
for(let j = 1; j <= 9; j ++) {
    sum2 += i * j;
}
console.log(sum2);

// Function
function times(a, b) {
    return a * b;
}
let x = times(4, 3);
console.log(x);
console.log(times(3));
console.log(times());

// Pass by value/reference - Primitive types are passed by value / Object and function are passed by reference!

// Lambda
(a, b) => a * b; 
(a, b) => { return a * b; }

setTimeout(function () {
    console.log("1 second later");
}, 1000);

setTimeout(() =>
    console.log("1 second later")
, 1000);

console.log(JSON.stringify({a: 10}));

let str = '{"a": 10}';
let obj = JSON.parse(str);
console.log(obj.a);

// Thanos
$("hand").click(
    function() {
        // start Thanos effect
        // set 10 ids for search results
        // randomly select 5 results
        let ids = [1, 3, 5, 7, 2];
        ids.forEach(id => {
            $("#" + id)... // scroll to the center of screen
            // todo: click -> $("#btn-" + id).click()
            $("#" + id).fadeOut();
            sleep(1000); // search
        });

        $(XXX).fadeOut();
    }
)

<p>the number of results if: <span id="number">12345</span></p>

let total = parseInt($("#number").innerHTML);
let step = total / 500;
for(let i = 0; i < 500; i ++) {
    total -= step;
    $("#number").innerHTML = total;
}