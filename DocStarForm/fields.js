function formGenerator(){
    inputObjs = $("input").select();
    var fields = [];
    for(i = 0; i < inputObjs.length; i++){
        fields.add(inputObjs[i].id)
    }
    console.log(fields);

}