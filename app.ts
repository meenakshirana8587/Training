import { Product } from "./product";

function getProduct(){
    let p = new Product();
    p.Id = "1";
    p.Price = 100;
    p.Title = "Cricket Bat";
    p.inStock = true;
    return p;
}

let p = getProduct();
console.log(p);

var isDone: boolean= false;
var age: number = 9;
var isFlag= true;
var abc : string= "data";
var list: Array<number> = [1,2,3];
console.log(isDone);
console.log(age);
console.log(isFlag);
console.log(abc);
console.log(list);

type Student = {
    name : string,
    grade : number,
    age : number
} 
 type Player = {
     name : string,
     sportsname: string
 }

 type StudentOrPlayer = Student | Player;
 type StudentAndPlayer = Student & Player;

 let uarray : StudentOrPlayer[] = [];
 let iarray : StudentAndPlayer[]= [];

 let spu1 : StudentOrPlayer= {
     name: "foo",
     grade: 6,
     age: 12 
 }

 uarray.push(spu1);

 let spu2 : StudentOrPlayer= {
    name: "koo",
    sportsname : "cricket"
}
uarray.push(spu2);

let spi1 : StudentAndPlayer= {
    name: "abc",
    age : 12, 
    grade : 6,
    sportsname : "basketball"


}
iarray.push(spi1);
let spi2 : StudentAndPlayer= {
    name: "xyz",
    grade: 7,
    age: 15,
    sportsname: "tennis"
}
iarray.push(spi2);

uandi(uarray);
uandi(iarray);
function uandi(id: StudentOrPlayer[] | StudentAndPlayer[])
{
    id.forEach(element => {
        console.log(element);
    })
}
