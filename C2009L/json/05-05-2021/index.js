var x = parseInt('10')
var y = parseInt('20')
console.log('x = '+(x+y))
var x1 = '123'
var x2 = '123'
//x1 va x2 bang nhau ve "gia tri"
if(x1 === x2) {
    console.log('bang nhauuuuu ke type and value')
}
var x3 = 4
for(let i = 0; i< 2; i++) {
    let x3 = 30
}
console.log(`x3 =${x3}`)
const PI = 3.1416
//thu tu uu tien: const(cao nhat) => let => var
//const tham chieu den 1 function
// function sum2Numbers(x, y) {
//     return x + y
// }
//const sum2Numbers = (x, y) => x + y
const sum2Numbers = (x, y) => {
    //debugger
    return x + y
}
console.log(`sum 3 and 5 is: ${sum2Numbers(3,5)}`)
//const sum2Numbers = (x, y) => x + y
//dau vao cua ham la 1 ham khac ?
/*
let seconds = 0
setInterval(async () => {
    seconds ++;
    console.log(`seconds = ${seconds}`)
}, 2000)
*/
//setTimeout = hay dung de gia lap 1 viec gi do

const doSomething = (param1, param2) => new Promise((resolve, reject) => {
    debugger
    console.log('bat dau viec 1')
    setTimeout(() => {    
        console.log('xong viec 1')    
        if(param1 == 1 && param2 == 2) {
            resolve({x: 10, y: 20})
        } else if(param1 == 3 && param2 == 4) {
            resolve({x: 50, y: 60})
        } else {
            reject({a: 1, b: 3})
        }        
    }, 2000)
})
function doSomething2() {
    console.log('bat dau viec 2')    
}
/*
doSomething(({x, y})=> {
    doSomething2(()=>{

    })
})
*/
/*
doSomething(6, 6).then(({x, y}) => {
    doSomething2()
}).catch(({a, b}) => {

})
*/
//async / await
async function do1And2() {
    try {
        await doSomething(1,2)
        await doSomething(4,5)
        //goi nhieu lan 
    }catch(exception) {
        console.log(`error = ${JSON.stringify(exception)}`)
    }
}
do1And2()
//bai tap nho: viet them doSomething2, chay sau doSomething
//bai tap de hon
//viet ham nhan 2 so
const sum = (x, y)
const sum = ({x, y})
