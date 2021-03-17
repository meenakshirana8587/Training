function counter()
{
    var count=0;
    function counts()
{
    count= count+1;
    console.log(count);

}

return counts;
}

var cnt= counter();
cnt();
cnt();
cnt();
cnt();