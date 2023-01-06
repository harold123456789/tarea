TablaHash h = new TablaHash(10);
Console.WriteLine("Tamaño de tabla creada: {0}", h.getSize());

//Console.Write("Registrar usuario");
//Console.WriteLine(" Usuario ");
//string nombre = Console.ReadLine();

//Console.WriteLine("Contraseña");
//string contraseña = Console.ReadLine();

//h.insertElement(nombre, contraseña);

//Console.Write("Login usuario");
//Console.WriteLine(" Usuario ");
//nombre = Console.ReadLine();

//Console.WriteLine("Contraseña");
//contraseña = Console.ReadLine();

//h.searchElement(nombre, contraseña);

public class Node
{

    int valor;
    string nombre;
    //string contraseña;
    Node next;

    public Node()
    {
        this.valor = 0;
        this.nombre = "";
        //this.contraseña ="";
        this.next = null;
    }

    //public Node(int valor, string nombre, string contraseña)
    {
        this.valor = valor;
        this.nombre = nombre;
        //this.contraseña = contraseña;
        this.next = null;
    }

    public int getValor()
    {
        return this.valor;
    }

    public string getNombre()
    {
        return this.nombre;
    }

    //public string getContraseña()
    //{
        //return this.contraseña;
    //}
    public Node getNext()
    {
        return this.next;
    }

    public void setValor(int valor)
    {
        this.valor = valor;
    }

    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }
    
    //public void setContraseña(string contraseña)
    //{
        //this.contraseña = contraseña;
    //}
    public void setNext(Node next)
    {
        this.next = next;
    }
};

public class ListaLigada
{
    Node head;

    public ListaLigada()
    {
        this.head = null;
    }

    public ListaLigada(Node n)
    {
        this.head = n;
    }
        
    public Node getHead()
    {
        return this.head;
    }

    public void setHead(Node h)
    {
        this.head = h;
    }
        
    public void printList()
    {
        Node temp = this.head;
        while(temp != null)
        {
            Console.WriteLine("Valor: {0}, Nombre: {1}", temp.getValor(), temp.getNombre());
            temp = temp.getNext();
        }
    }
};

public class TablaHash
{
    ListaLigada[] l;
    int size;
    public TablaHash(int size)
    {
        l = new ListaLigada[size];
        this.size = size;
        for(int i = 0; i < size; i++)
        {
            l[i] = new ListaLigada();
        }
    }

    public ListaLigada getLista(uint k)
    {
        return this.l[k];
    }

    public int getSize()
    {
        return this.size;
    }

    private uint hash(string s)
    {
        uint sum = 0;
        for(int i = 0; i < s.Length; i++)
        {
            sum += s[i];
        }
        return sum;
    }

    public void insertElement(string s, //string c)
    {
        uint vhash = this.hash(s);
        Node n = new Node((int)vhash, s,//c);
        n.setNext(this.l[vhash % this.size].getHead());
        this.l[vhash % this.size].setHead(n);
    }

    public bool searchElement(string s, string contraseña)
    {
        uint vhash = this.hash(s);
        Node temp = this.l[vhash % this.size].getHead();
        while(temp != null)
        {
            if( string.Compare(s, temp.getNombre()) == 0 && temp.getContraseña() //== contraseña);
            {
                //Console.WriteLine("Login Correcto");
                return true;
            }
            temp = temp.getNext();
        }
        //Console.WriteLine("Login Incorrecto");
        return false;
    }
    
};