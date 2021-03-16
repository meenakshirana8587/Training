(function (){
    console.log("two way data binding");
    var elements= document.querySelectorAll('[data-day2]');
    var dbrepo= {};

    elements.forEach((element) => {

        if(element.type === 'text'){
            var bindingProperty = element.getAttribute('data-day2');
            addToScope();
            element.onkeyup = () => {
                dbrepo[bindingProperty] = element.value;
            }
        }

        function addToScope()

        {
            if(!dbrepo.hasOwnProperty(bindingProperty))
            {
                let value;
                Object.defineProperty(dbrepo, bindingProperty, {
                    configurable : true,
                    enumerable : true,
                    set: function (newvalue)
                    {
                        value= newvalue;
                        elements.forEach(e=>{
                            if(e.getAttribute('data-day2') === bindingProperty)
                            {
                                if(e.type === 'text')
                                {
                                    e.value= newvalue;
                                }
                                else if (!e.type)
                                {
                                    e.innerHTML = newvalue;
                                }
                            }
                        })
                    },
                    get : function()
                    {
                        return value;
                    }

                })
            }
        }
    });
})();