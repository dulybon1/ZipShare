$(document).ready(function(){
    $.getJSON("../js/states.json", function(data){

        var stateDropdown = $("#stateDropdown");
        //stateDropdown.empty();

        for(var item in data)
        {
            var option = new Option(data[item].value,data[item].text)
            $(option).html(data[item].text)
            stateDropdown.append(option);
        }
    }); 
});
