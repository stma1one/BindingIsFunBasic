using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingIsFun.Models;

 public class Pokemon
{
    
    public int Id {	get; set; }
	public string? Name{ get; set;	}
	
	public string? Type	{ get; set;	}
	public int Hitpoints { get; set; }
    public string? Location { get; set; }
    public string? ImageUrl { get; set; }

    

    
}

