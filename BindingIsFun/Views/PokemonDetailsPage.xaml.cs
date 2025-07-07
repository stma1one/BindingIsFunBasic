using BindingIsFun.Models;
using static System.Net.WebRequestMethods;

namespace BindingIsFun.Views;

public partial class PokemonDetailsPage : ContentPage
{
	Pokemon pokemon;
	public PokemonDetailsPage()
	{
		pokemon = new Pokemon()
		{
			Name ="Bublbasaur",
			Id = 1,
			Hitpoints = 45,
			Type = "Grass",
			Location = "Kanto region,Route 2",
			ImageUrl=null
		};

		InitializeComponent();
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		pokemon.ImageUrl = @"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png";
		OnPropertyChanged(nameof(pokemon));
    }
}