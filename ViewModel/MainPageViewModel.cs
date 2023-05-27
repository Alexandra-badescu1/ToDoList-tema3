using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;
using ToDoList.Model;
using TODOlist.ViewModel;

namespace ToDoList.ViewModel;
public partial class MainPageViewModel: BaseViewModel
{
    public MainPageViewModel()
    {
        iteams = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> iteams;

    [ObservableProperty]
    string text;


    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(text))
            return;
        iteams.Add(text);
        text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (iteams.Contains(s))
            iteams.Remove(s);
    }

   
}