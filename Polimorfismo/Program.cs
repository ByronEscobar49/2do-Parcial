using Polimorfismo;
Bar oBar = new Bar();

Persona oCliente = new Cliente("Joel");
Persona oMesero = new Mesero("Willian");
Persona oCantinero = new Cantinero("Byron");
oBar.Entrar(oCliente);
oBar.Entrar(oMesero);
oBar.Entrar(oCantinero);
