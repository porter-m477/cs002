
public class Agenda
{
    private List<Contacto> contactos;

    public Agenda()
    {
        contactos = new List<Contacto>(){};
    }
    public void InsertarContacto(Contacto contacto)
    {
        contactos.Add(contacto);
    }
    public List<Contacto> BuscarNombre(string nombre)
    {
        return  contactos.Where(x => x.Nombre.Contains(nombre)).ToList();
    }
    public List<Contacto> BuscarTelefono(string telefono)
    {
        return  contactos.Where(x => x.Telefono.Contains(telefono)).ToList();
    }
    public List<Contacto> VerContactos()
    {
        return contactos.ToList();
    }
    public string EliminarContacto(string telefono)
    {
        Contacto elimContacto = contactos.Find(x => x.Telefono == telefono);
        var buscar = contactos.Where(x => x.Telefono == telefono).ToList();
        if(buscar.Any()){
            contactos.Remove(elimContacto);
            foreach (var conta in buscar) 
            {
                return $"Contacto {conta.Nombre} eliminado.";
            }
        }
        return "No existe contacto";
    }
}