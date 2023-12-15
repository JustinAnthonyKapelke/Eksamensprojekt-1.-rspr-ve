﻿using Microsoft.Identity.Client.Extensions.Msal;
using Nordlangelands_Tækkemand.Commands;
using Nordlangelands_Tækkemand.Interfaces;
using Nordlangelands_Tækkemand.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Media3D;

namespace Nordlangelands_Tækkemand.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        //public CreateMaterialWindow CreateMaterialWindow { get; set; }
        // INotifyPropertyChanged EventHandler
        public event PropertyChangedEventHandler? PropertyChanged;

        // INotifyPropertyChanged Method
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Command Properties
        public ICommand AddStockCountCMD { get; set; } = new AddStockCountCommand();
        public ICommand CreateMaterialCMD { get; set; } = new CreateMaterialCommand();
        public ICommand DeleteMaterialCMD { get; set; } = new DeleteMaterialCommand();
        public ICommand FilterMaterialCMD { get; set; } = new FilterMaterialCommand();
        public ICommand LogTextCMD { get; set; } = new LogTextCommand();
        public ICommand OpenCreateMaterialCMD { get; set; } = new OpenCreateMaterialWindowCommand();
        public ICommand OpenUpdateMaterialCMD { get; set; } = new OpenUpdateMaterialWindowCommand();
        public ICommand OpenWorkplaceCMD { get; set; } = new OpenWorkplaceWindowCommand();
        public ICommand RemoveStockCountCMD { get; set; } = new RemoveStockCountCommand();
        public ICommand SearchMaterialCMD { get; set; } = new SearchMaterialCommand();
        public ICommand UpdateMaterialCMD { get; set; } = new UpdateMaterialCommand();
        public ICommand WorkplaceAddStockCountCMD { get; set; } = new WorkplaceAddStockCountCommand();
        public ICommand LoginCMD { get; set; } = new LoginCommand();

        //Fields
        private string _logText;
        private string _searchText;
        private object _currentVM;
        private IMaterialViewModel _selectedMaterial;
        private WorkplaceViewModel _selectedWorkplace;
        private string _selectedMaterialType;
        private MainWindow _mainWindowInstance;
        private WorkplaceMaterialViewModel _workplaceSelectedMaterial;
        //private bool _isThatchingTypeChecked; // husk at fjerne denne

        //LogText Property
        public string LogText
        {
            get { return _logText; }
            set
            {
                if (_logText != value)
                {
                    _logText = value;
                    OnPropertyChanged(nameof(LogText)); // Implement INotifyPropertyChanged
                }
            }
        }      

        //SearchText Property
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged(nameof(SearchText)); // Implement INotifyPropertyChanged

                }
            }
        }

        //Selected Material Property
        public IMaterialViewModel SelectedMaterial
        {
            get { return _selectedMaterial; }
            set
            {
                if (_selectedMaterial != value )
                {
                    _selectedMaterial = value;
                    OnPropertyChanged("SelectedMaterial");
                }
            }
        }


        //Selected WorkplaceMaterial Property
        public WorkplaceMaterialViewModel WorkplaceSelectedMaterial
        {
            get { return _workplaceSelectedMaterial; }
            set
            {
                if (_workplaceSelectedMaterial != value)
                {
                    _workplaceSelectedMaterial = value;
                    OnPropertyChanged("WorkplaceSelectedMaterial");
                }
            }
        }

        //SelectedMaterialType Property
        public string SelectedMaterialType
        {
            get { return _selectedMaterialType; }
            set
            {
                if (_selectedMaterialType != value)
                {
                    _selectedMaterialType = value;
                    OnPropertyChanged(nameof(SelectedMaterialType));                    
                }
            }
        }

        //SelectedWorkplace Property
        public WorkplaceViewModel SelectedWorkplace
        {
            get { return _selectedWorkplace; }
            set
            {
                if (_selectedWorkplace != value)
                {
                    _selectedWorkplace = value;
                    OnPropertyChanged("SelectedWorkplace");
                }
            }
        }

        // Current ViewModel object to store the selected viewmodel. It is used to change datacontext for the materialListbox
        public object CurrentVM
        {
            get { return _currentVM; }
            set
            {
                if (_currentVM != value)
                {
                    _currentVM = value;
                    OnPropertyChanged(nameof(CurrentVM));
                }
            }
        }
        
        public MainWindow MainWindowInstance
        {
            get { return _mainWindowInstance; }
            set
            {
                if (_mainWindowInstance != value)
                {
                    _mainWindowInstance = value;
                    OnPropertyChanged(nameof(MainWindow));
                }
            }
        }
        
        //public bool IsThatchingTypeChecked
        //{
        //    get => _isThatchingTypeChecked;
        //    set
        //    {
        //        if (_isThatchingTypeChecked != value)
        //        {
        //            _isThatchingTypeChecked = value;
        //            OnPropertyChanged(nameof(IsThatchingTypeChecked)); // Ensure this calls PropertyChanged event
        //        }
        //    }
        //}
        
        //ViewModel Properties
        public ThatchingViewModel TVM { get; set; }
        public VariousViewModel VVM { get; set; }
        public WoodViewModel WDVM { get; set; }
        public WorkplaceViewModel WKVM { get; set; }
        public WorkplaceMaterialViewModel WKMVM { get; set; }
        public UserViewModel UVM { get; set; }


        //ObservableCollection Fields
        private ObservableCollection<ThatchingViewModel> _thatchingVM;
        private ObservableCollection<VariousViewModel> _variousVM;
        private ObservableCollection<WoodViewModel> _woodVM;
        private ObservableCollection<WorkplaceViewModel> _workplaceVM;
        private ObservableCollection<IMaterialViewModel> _allMaterialsVM;
        private ObservableCollection<WorkplaceMaterialViewModel> _workplaceMaterialsVM;
        private ObservableCollection<UserViewModel> _userVM;

        //Observable Collection Properties       
        public ObservableCollection<ThatchingViewModel> ThatchingVM
        {
            get { return _thatchingVM; }
            set
            {
                _thatchingVM = value;
                OnPropertyChanged(nameof(ThatchingVM));
            }
        }

        public ObservableCollection<VariousViewModel> VariousVM
        {
            get { return _variousVM; }
            set
            {
                _variousVM = value;
                OnPropertyChanged(nameof(VariousVM));
            }
        }

        public ObservableCollection<WoodViewModel> WoodVM
        {
            get { return _woodVM; }
            set
            {
                _woodVM = value;
                OnPropertyChanged(nameof(WoodVM));
            }
        }

        public ObservableCollection<IMaterialViewModel> AllMaterialsVM
        {
            get { return _allMaterialsVM; }
            set
            {
                _allMaterialsVM = value;
                OnPropertyChanged(nameof(AllMaterialsVM));
            }
        }

        public ObservableCollection<WorkplaceMaterialViewModel> WorkplaceMaterialsVM
        {
            get { return _workplaceMaterialsVM; }
            set
            {
                _workplaceMaterialsVM = value;
                OnPropertyChanged(nameof(WorkplaceMaterialsVM));
            }
        }

        public ObservableCollection<WorkplaceViewModel> WorkplaceVM
        {
            get { return _workplaceVM; }
            set
            {
                _workplaceVM = value;
                OnPropertyChanged(nameof(WorkplaceVM));
            }
        }

        public ObservableCollection<UserViewModel> UserVM
        {
            get { return _userVM; }
            set
            {
                _userVM = value;
                OnPropertyChanged(nameof(UserVM));
            }
        }

        //Constructor
        public MainViewModel(MainWindow mainWindow)
        {
            //Instantiate ObservableCollections
            _mainWindowInstance = mainWindow;
            ThatchingVM = new ObservableCollection<ThatchingViewModel>();
            VariousVM = new ObservableCollection<VariousViewModel>();
            WoodVM = new ObservableCollection<WoodViewModel>();
            WorkplaceVM = new ObservableCollection<WorkplaceViewModel>();          
            AllMaterialsVM = new ObservableCollection<IMaterialViewModel>();
            WorkplaceMaterialsVM = new ObservableCollection<WorkplaceMaterialViewModel>();
            UserVM = new ObservableCollection<UserViewModel>();

            //Instantiate ViewModels
            TVM = new ThatchingViewModel(new ThatchingMaterial());
            VVM = new VariousViewModel(new VariousMaterial());
            WDVM = new WoodViewModel(new WoodMaterial());
            WKVM = new WorkplaceViewModel(new Workplace());
            WKMVM = new WorkplaceMaterialViewModel(new WorkplaceMaterial());
            UVM = new UserViewModel(new User());

            //Initialize ViewModels
            ThatchingVM.Clear();
            InitializeThatchingVM();
            VariousVM.Clear();
            InitializeVariousVM();
            WoodVM.Clear(); 
            InitializeWoodVM();
            InitializeAllMaterialsVM();
            InitializeWorkplaceVM();  
        }

        //Methods
        public void InitializeThatchingVM()
        {  
            List<ThatchingMaterial> thatchingMaterials = TVM.thatchingRepo.GetAllMaterials();

            // Go through each of the materials from the repository and create a ThatchingViewModel for them
            foreach (ThatchingMaterial material in thatchingMaterials)
            {
                ThatchingVM.Add(new ThatchingViewModel(material));
            }
        }

        public void InitializeVariousVM()
        {
            List<VariousMaterial> variousMaterials = VVM.variousRepo.GetAllMaterials();

            // Go through each of the materials from the repository and create a VariousViewModel for them
            foreach (VariousMaterial material in variousMaterials)
            {
                VariousVM.Add(new VariousViewModel(material));
            }
        }

        public void InitializeWoodVM()
        {
            List<WoodMaterial> woodMaterials = WDVM.woodRepo.GetAllMaterials();

            // Go through each of the materials from the repository and create a WoodViewModel for them
            foreach (WoodMaterial material in woodMaterials)
            {
                WoodVM.Add(new WoodViewModel(material));
            }
        }

        public void InitializeAllMaterialsVM()
        {
            // Add Thatching materials to the AllMaterials collection
            foreach (var thatchingViewModel in ThatchingVM)
            {
                AllMaterialsVM.Add(thatchingViewModel);
            }

            // Add Various materials to the AllMaterials collection
            foreach (var variousViewModel in VariousVM)
            {
                AllMaterialsVM.Add(variousViewModel);
            }

            // Add Wood materials to the AllMaterials collection
            foreach (var woodViewModel in WoodVM)
            {
                AllMaterialsVM.Add(woodViewModel);
            }
        }
       
        public void InitializeWorkplaceVM()
        {
            List<Workplace> workplaces = WKVM.workplaceRepo.GetAllWorkplaces();

            // Go through each of the materials from the repository and create a VariousViewModel for them
            foreach (Workplace workplace in workplaces)
            {
                WorkplaceVM.Add(new WorkplaceViewModel(workplace));
            }
        }

        public void InitializeWorkplaceMaterialsVM()
        {      
            List<WorkplaceMaterial> workplaceMaterials = WKMVM.WorkplaceMaterialRepo.GetAll();

            // Go through each of the materials from the repository and create a WoodViewModel for them
            foreach (WorkplaceMaterial workplaceMaterial in workplaceMaterials)
            {
                WorkplaceMaterialsVM.Add(new WorkplaceMaterialViewModel(workplaceMaterial));
            }
        }

        public void InitializUserVM()
        {
            List<User> users = UVM.UserRepo.GetAllUsers();

            // Go through each of the materials from the repository and create a VariousViewModel for them
            foreach (User user in users)
            {
                UserVM.Add(new UserViewModel(user));
            }
        }
    }
}
