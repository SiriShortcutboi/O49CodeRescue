class player{

public string n;
public int h;
public int xp;

public void dmg(int a){
h=h-a;
Console.WriteLine("player took damage");
}

public void addxp(int x){
xp=xp+x;
}

public void show(){
Console.WriteLine(n+" hp:"+h+" xp:"+xp);
}
}