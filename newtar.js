function Car(name,price)
{
    if(!new.target)
{
    throw new Error ("use new keyword for creating an object");
}
    this.name= name;
    this.price= price;


}
try{
let c1=  new Car("M Suzuki", 100);
console.log(c1);

let c2=  new Car("Toyota", 200);
console.log(c2);

}
catch(err)
{
    console.log(err.message);
}

