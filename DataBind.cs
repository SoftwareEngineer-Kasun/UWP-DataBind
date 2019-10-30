//axml inside
Text="{Binding name}" // bind name

//C#
create a class to manipulate data

class Test{
private string x;
public string Password{
get{
return x;
}
set{
x=value;
}

}
}

//code in the UI call

//create am instence of that class
Test test=new Test();

// load that to the UI
this.DataContext=Test;

// add data to the class
public void AddData(){

test.Password.x=123456; //set value

}
