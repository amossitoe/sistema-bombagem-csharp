using System;
class Equipamento {
    
    protected string id;
    protected bool ligada, aberta;
    
    public Equipamento(string id, bool ligada, bool aberta){
        this.id=id;
        this.ligada=ligada;
        this.aberta=aberta;
    }
    public string getId(){
        return id;
    }
    public bool getLigada(){
        return ligada;
    }
    public bool getAberta(){
        return aberta;
    }
    public virtual void ligar(){
        if(ligada==false){
            ligada=true;
            Console.WriteLine($"{id} está LIGADO.");
        }
    }
    public virtual void desligar(){
        if(ligada==true){
            ligada=false;
            Console.WriteLine($"{id} está DESLIGADO.");
        }
    }
    public virtual void abrir(){
        if(aberta==false){
            aberta=true;
            Console.WriteLine($"{id} está ABERTA.");
        }
    }
    public virtual void fechar(){
        if(aberta==true){
            aberta=false;
            Console.WriteLine($"{id} está FECHADA.");
        }
    }
    public void mostrarDados(){
        string estadoEquipamento=ligada? "LIGADA":"DESLIGADA";
        string estadoValvula=aberta? "ABERTA":"FECHADA";
        Console.WriteLine($"{id} | Equipamento: {estadoEquipamento} | Válvula: {estadoValvula}");
    }
}
class Bomba:Equipamento{

public Bomba(string id, bool ligada, bool aberta):base(id, ligada, aberta){
}
public override void ligar(){
        if(ligada==false){
            ligada=true;
            Console.WriteLine($"{id} está LIGADO.");
        }
    }
    public override void desligar(){
        if(ligada==true){
            ligada=false;
            Console.WriteLine($"{id} está DESLIGADO.");
        }
    }
}
class Valvula:Equipamento{

public Valvula(string id, bool ligada, bool aberta):base(id, ligada, aberta){
}
public override void abrir(){
        if(aberta==false){
            aberta=true;
            Console.WriteLine($"{id} está ABERTA.");
        }
    }
    public override void fechar(){
        if(aberta==true){
            aberta=false;
            Console.WriteLine($"{id} está FECHADA.");
        }
    }
}

   class EquipamentoTeste{
  static void Main(string[] args) {

    Bomba b1 = new Bomba("Grundfos 01", false, false);
    Valvula v1 = new Valvula("Monovar 01", false, false);

    Console.WriteLine("====Arranque do Sistema====");
    v1.abrir();
    b1.ligar();

    Console.WriteLine("====Paragem do Sistema====");
    b1.desligar();
    v1.fechar();

    Console.WriteLine("====Estado Final do Sistema====");
    Console.WriteLine($"{b1.getId()} | Ligada: {(b1.getLigada() ? "SIM" : "NÃO")}");
    Console.WriteLine($"{v1.getId()} | Aberta: {(v1.getAberta() ? "SIM" : "NÃO")}");
}
}
