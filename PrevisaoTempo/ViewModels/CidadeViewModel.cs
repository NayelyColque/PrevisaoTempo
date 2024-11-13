/* using PrevisaoTempo.Models;
using PrevisaoTempo.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PrevisaoTempo.ViewModels
{
    public partial class CidadeViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Cidade>? _cidades;

        [ObservableProperty] private string _nomeCidade;

        public ICommand getCidadesCommand { get; set; }

        public CidadeViewModel()
        {
            getCidadesCommand = new Command(getCidades);
        }

        public async void getCitys()
        {
            CidadeService locateCityService = new();
            Cidades = await locateCityService.FetchCidades(NomeCidade);
        }

    }
}*/

using CommunityToolkit.Mvvm.ComponentModel;
using PrevisaoTempo.Models;
using PrevisaoTempo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrevisaoTempo.ViewModels
{
    public partial class CidadeViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Cidade>? cidades;

        public ICommand getPostsCommand { get; set; }

        public CidadeViewModel()
        {
            getPostsCommand = new Command(getCidades);
        }

        public async void getPosts()
        {
            CidadeService postService = new();
            Cidades = await postService.FetchCidades();
        }
    }
}