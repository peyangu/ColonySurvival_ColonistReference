using ColonySurvivalColonistReference.Json;
using ColonySurvivalColonistReference.ViewModel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ColonySurvivalColonistReference.Model
{
    public class MainWindowModel : ModelBase
    {
        #region プロパティ
        private string _JsonFilePath = "";
        public string JsonFilePath
        {
            get { return _JsonFilePath; }
            set
            {
                if (_JsonFilePath != value)
                {
                    _JsonFilePath = value;

                    RaisePropertyChanged(nameof(JsonFilePath));
                }
            }
        }

        private float _WarterMarkOpacity = 0.3f;
        public float WarterMarkOpacity
        {
            get { return _WarterMarkOpacity; }
            set
            {
                if (_WarterMarkOpacity != value)
                {
                    _WarterMarkOpacity = value;

                    RaisePropertyChanged(nameof(WarterMarkOpacity));
                }
            }
        }

        private int _BerryfarmerColonist = 0;
        public int BerryfarmerColonist
        {
            get { return _BerryfarmerColonist; }
            set
            {
                if (_BerryfarmerColonist != value)
                {
                    _BerryfarmerColonist = value;

                    RaisePropertyChanged(nameof(BerryfarmerColonist));
                }
            }
        }

        private int _GuardslingerdayColonist = 0;
        public int GuardslingerdayColonist
        {
            get { return _GuardslingerdayColonist; }
            set
            {
                if (_GuardslingerdayColonist != value)
                {
                    _GuardslingerdayColonist = value;

                    RaisePropertyChanged(nameof(GuardslingerdayColonist));
                }
            }
        }

        private int _GuardbowdayColonist = 0;
        public int GuardbowdayColonist
        {
            get { return _GuardbowdayColonist; }
            set
            {
                if (_GuardbowdayColonist != value)
                {
                    _GuardbowdayColonist = value;

                    RaisePropertyChanged(nameof(GuardbowdayColonist));
                }
            }
        }

        private int _GuardcrossbowdayColonist = 0;
        public int GuardcrossbowdayColonist
        {
            get { return _GuardcrossbowdayColonist; }
            set
            {
                if (_GuardcrossbowdayColonist != value)
                {
                    _GuardcrossbowdayColonist = value;

                    RaisePropertyChanged(nameof(GuardcrossbowdayColonist));
                }
            }
        }

        private int _GuardmatchlockdayColonist = 0;
        public int GuardmatchlockdayColonist
        {
            get { return _GuardmatchlockdayColonist; }
            set
            {
                if (_GuardmatchlockdayColonist != value)
                {
                    _GuardmatchlockdayColonist = value;

                    RaisePropertyChanged(nameof(GuardmatchlockdayColonist));
                }
            }
        }

        private int _GuardslingernightColonist = 0;
        public int GuardslingernightColonist
        {
            get { return _GuardslingernightColonist; }
            set
            {
                if (_GuardslingernightColonist != value)
                {
                    _GuardslingernightColonist = value;

                    RaisePropertyChanged(nameof(GuardslingernightColonist));
                }
            }
        }

        private int _GuardbownightColonist = 0;
        public int GuardbownightColonist
        {
            get { return _GuardbownightColonist; }
            set
            {
                if (_GuardbownightColonist != value)
                {
                    _GuardbownightColonist = value;

                    RaisePropertyChanged(nameof(GuardbownightColonist));
                }
            }
        }

        private int _GuardcrossbownightColonist = 0;
        public int GuardcrossbownightColonist
        {
            get { return _GuardcrossbownightColonist; }
            set
            {
                if (_GuardcrossbownightColonist != value)
                {
                    _GuardcrossbownightColonist = value;

                    RaisePropertyChanged(nameof(GuardcrossbownightColonist));
                }
            }
        }

        private int _GuardmatchlocknightColonist = 0;
        public int GuardmatchlocknightColonist
        {
            get { return _GuardmatchlocknightColonist; }
            set
            {
                if (_GuardmatchlocknightColonist != value)
                {
                    _GuardmatchlocknightColonist = value;

                    RaisePropertyChanged(nameof(GuardmatchlocknightColonist));
                }
            }
        }

        private int _MinerjobColonist = 0;
        public int MinerjobColonist
        {
            get { return _MinerjobColonist; }
            set
            {
                if (_MinerjobColonist != value)
                {
                    _MinerjobColonist = value;

                    RaisePropertyChanged(nameof(MinerjobColonist));
                }
            }
        }

        private int _ForesterColonist = 0;
        public int ForesterColonist
        {
            get { return _ForesterColonist; }
            set
            {
                if (_ForesterColonist != value)
                {
                    _ForesterColonist = value;

                    RaisePropertyChanged(nameof(ForesterColonist));
                }
            }
        }

        private int _FlaxfarmerColonist = 0;
        public int FlaxfarmerColonist
        {
            get { return _FlaxfarmerColonist; }
            set
            {
                if (_FlaxfarmerColonist != value)
                {
                    _FlaxfarmerColonist = value;

                    RaisePropertyChanged(nameof(FlaxfarmerColonist));
                }
            }
        }

        private int _AlkanetfarmerColonist = 0;
        public int AlkanetfarmerColonist
        {
            get { return _AlkanetfarmerColonist; }
            set
            {
                if (_AlkanetfarmerColonist != value)
                {
                    _AlkanetfarmerColonist = value;

                    RaisePropertyChanged(nameof(AlkanetfarmerColonist));
                }
            }
        }

        private int _HollyhockfarmerColonist = 0;
        public int HollyhockfarmerColonist
        {
            get { return _HollyhockfarmerColonist; }
            set
            {
                if (_HollyhockfarmerColonist != value)
                {
                    _HollyhockfarmerColonist = value;

                    RaisePropertyChanged(nameof(HollyhockfarmerColonist));
                }
            }
        }

        private int _WolfsbanefarmColonist = 0;
        public int WolfsbanefarmColonist
        {
            get { return _WolfsbanefarmColonist; }
            set
            {
                if (_WolfsbanefarmColonist != value)
                {
                    _WolfsbanefarmColonist = value;

                    RaisePropertyChanged(nameof(WolfsbanefarmColonist));
                }
            }
        }

        private int _WheatfarmerColonist = 0;
        public int WheatfarmerColonist
        {
            get { return _WheatfarmerColonist; }
            set
            {
                if (_WheatfarmerColonist != value)
                {
                    _WheatfarmerColonist = value;

                    RaisePropertyChanged(nameof(WheatfarmerColonist));
                }
            }
        }

        private int _DyerColonist = 0;
        public int DyerColonist
        {
            get { return _DyerColonist; }
            set
            {
                if (_DyerColonist != value)
                {
                    _DyerColonist = value;

                    RaisePropertyChanged(nameof(DyerColonist));
                }
            }
        }

        private int _StonemasonColonist = 0;
        public int StonemasonColonist
        {
            get { return _StonemasonColonist; }
            set
            {
                if (_StonemasonColonist != value)
                {
                    _StonemasonColonist = value;

                    RaisePropertyChanged(nameof(StonemasonColonist));
                }
            }
        }

        private int _GunsmithjobColonist = 0;
        public int GunsmithjobColonist
        {
            get { return _GunsmithjobColonist; }
            set
            {
                if (_GunsmithjobColonist != value)
                {
                    _GunsmithjobColonist = value;

                    RaisePropertyChanged(nameof(GunsmithjobColonist));
                }
            }
        }

        private int _MerchantColonist = 0;
        public int MerchantColonist
        {
            get { return _MerchantColonist; }
            set
            {
                if (_MerchantColonist != value)
                {
                    _MerchantColonist = value;

                    RaisePropertyChanged(nameof(MerchantColonist));
                }
            }
        }

        private int _MinterColonist = 0;
        public int MinterColonist
        {
            get { return _MinterColonist; }
            set
            {
                if (_MinterColonist != value)
                {
                    _MinterColonist = value;

                    RaisePropertyChanged(nameof(MinterColonist));
                }
            }
        }

        private int _TailorColonist = 0;
        public int TailorColonist
        {
            get { return _TailorColonist; }
            set
            {
                if (_TailorColonist != value)
                {
                    _TailorColonist = value;

                    RaisePropertyChanged(nameof(TailorColonist));
                }
            }
        }

        private int _TechnologistColonist = 0;
        public int TechnologistColonist
        {
            get { return _TechnologistColonist; }
            set
            {
                if (_TechnologistColonist != value)
                {
                    _TechnologistColonist = value;

                    RaisePropertyChanged(nameof(TechnologistColonist));
                }
            }
        }

        private int _KilnjobColonist = 0;
        public int KilnjobColonist
        {
            get { return _KilnjobColonist; }
            set
            {
                if (_KilnjobColonist != value)
                {
                    _KilnjobColonist = value;

                    RaisePropertyChanged(nameof(KilnjobColonist));
                }
            }
        }

        private int _FineryforgejobColonist = 0;
        public int FineryforgejobColonist
        {
            get { return _FineryforgejobColonist; }
            set
            {
                if (_FineryforgejobColonist != value)
                {
                    _FineryforgejobColonist = value;

                    RaisePropertyChanged(nameof(FineryforgejobColonist));
                }
            }
        }

        private int _WoodcutterColonist = 0;
        public int WoodcutterColonist
        {
            get { return _WoodcutterColonist; }
            set
            {
                if (_WoodcutterColonist != value)
                {
                    _WoodcutterColonist = value;

                    RaisePropertyChanged(nameof(WoodcutterColonist));
                }
            }
        }

        private int _BloomeryjobColonist = 0;
        public int BloomeryjobColonist
        {
            get { return _BloomeryjobColonist; }
            set
            {
                if (_BloomeryjobColonist != value)
                {
                    _BloomeryjobColonist = value;

                    RaisePropertyChanged(nameof(BloomeryjobColonist));
                }
            }
        }

        private int _MetalsmithjobColonist = 0;
        public int MetalsmithjobColonist
        {
            get { return _MetalsmithjobColonist; }
            set
            {
                if (_MetalsmithjobColonist != value)
                {
                    _MetalsmithjobColonist = value;

                    RaisePropertyChanged(nameof(MetalsmithjobColonist));
                }
            }
        }

        private int _SmelterColonist = 0;
        public int SmelterColonist
        {
            get { return _SmelterColonist; }
            set
            {
                if (_SmelterColonist != value)
                {
                    _SmelterColonist = value;

                    RaisePropertyChanged(nameof(SmelterColonist));
                }
            }
        }

        private int _BakerColonist = 0;
        public int BakerColonist
        {
            get { return _BakerColonist; }
            set
            {
                if (_BakerColonist != value)
                {
                    _BakerColonist = value;

                    RaisePropertyChanged(nameof(BakerColonist));
                }
            }
        }

        private int _GrinderColonist = 0;
        public int GrinderColonist
        {
            get { return _GrinderColonist; }
            set
            {
                if (_GrinderColonist != value)
                {
                    _GrinderColonist = value;

                    RaisePropertyChanged(nameof(GrinderColonist));
                }
            }
        }

        private int _ScientistColonist = 0;
        public int ScientistColonist
        {
            get { return _ScientistColonist; }
            set
            {
                if (_ScientistColonist != value)
                {
                    _ScientistColonist = value;

                    RaisePropertyChanged(nameof(ScientistColonist));
                }
            }
        }

        private int _CrafterColonist = 0;
        public int CrafterColonist
        {
            get { return _CrafterColonist; }
            set
            {
                if (_CrafterColonist != value)
                {
                    _CrafterColonist = value;

                    RaisePropertyChanged(nameof(CrafterColonist));
                }
            }
        }
        #endregion

        OpenFileDialog dialog = new OpenFileDialog();
        List<Localhost> npcList;

        public ICommand ReferenceButtonClickCommand { get; private set; }

        public ICommand ReloadCommand { get; private set; }

        public MainWindowModel()
        {
            ReferenceButtonClickCommand = CreateCommand(v => SelectJsonFile());
            ReloadCommand = CreateCommand(v => Reload());
        }

        public void SelectJsonFile()
        {
            dialog.Title = "ファイルを開く(npc.jsonの指定)";
            dialog.Filter = "JSONファイル(.json)|*.json";
            if (dialog.ShowDialog() == true)
            {
                WarterMarkOpacity = 0;
                JsonFilePath = dialog.FileName;

                DisplayColonistInformation();
            }
        }

        private void DisplayColonistInformation()
        {
            if (!string.IsNullOrEmpty(JsonFilePath))
            {
                using (StreamReader r = new StreamReader(JsonFilePath))
                {
                    var json = r.ReadToEnd();
                    npcList = JsonUtil.ReadJSON(json.Substring(18, json.Length - 19).Replace("\r\n", "").Replace("\t", ""));
                }

                foreach (Localhost n in npcList)
                {
                    switch (n.type.Replace("pipliz.", ""))
                    {
                        case "berryfarmer":
                            BerryfarmerColonist++;
                            break;
                        case "guardslingerday":
                            GuardslingerdayColonist++;
                            break;
                        case "guardbowday":
                            GuardbowdayColonist++;
                            break;
                        case "guardcrossbowday":
                            GuardcrossbowdayColonist++;
                            break;
                        case "guardmatchlockday":
                            GuardmatchlockdayColonist++;
                            break;
                        case "guardslingernight":
                            GuardslingernightColonist++;
                            break;
                        case "guardbownight":
                            GuardbownightColonist++;
                            break;
                        case "guardcrossbownight":
                            GuardcrossbownightColonist++;
                            break;
                        case "guardmatchlocknight":
                            GuardmatchlocknightColonist++;
                            break;
                        case "minerjob":
                            MinerjobColonist++;
                            break;
                        case "forester":
                            ForesterColonist++;
                            break;
                        case "flaxfarmer":
                            FlaxfarmerColonist++;
                            break;
                        case "alkanetfarmer":
                            AlkanetfarmerColonist++;
                            break;
                        case "hollyhockfarmer":
                            HollyhockfarmerColonist++;
                            break;
                        case "wolfsbanefarm":
                            WolfsbanefarmColonist++;
                            break;
                        case "wheatfarmer":
                            WheatfarmerColonist++;
                            break;
                        case "dyer":
                            DyerColonist++;
                            break;
                        case "stonemason":
                            StonemasonColonist++;
                            break;
                        case "gunsmithjob":
                            GunsmithjobColonist++;
                            break;
                        case "merchant":
                            MerchantColonist++;
                            break;
                        case "minter":
                            MinterColonist++;
                            break;
                        case "tailor":
                            TailorColonist++;
                            break;
                        case "technologist":
                            TechnologistColonist++;
                            break;
                        case "kilnjob":
                            KilnjobColonist++;
                            break;
                        case "fineryforgejob":
                            FineryforgejobColonist++;
                            break;
                        case "woodcutter":
                            WoodcutterColonist++;
                            break;
                        case "bloomeryjob":
                            BloomeryjobColonist++;
                            break;
                        case "metalsmithjob":
                            MetalsmithjobColonist++;
                            break;
                        case "smelter":
                            SmelterColonist++;
                            break;
                        case "baker":
                            BakerColonist++;
                            break;
                        case "grinder":
                            GrinderColonist++;
                            break;
                        case "scientist":
                            ScientistColonist++;
                            break;
                        case "crafter":
                            CrafterColonist++;
                            break;
                    }
                }
            }
        }

        private void Reload()
        {
            // すべての初期化
            BerryfarmerColonist = 0;
            GuardslingerdayColonist = 0;
            GuardbowdayColonist = 0;
            GuardcrossbowdayColonist = 0;
            GuardmatchlockdayColonist = 0;
            GuardslingernightColonist = 0;
            GuardbownightColonist = 0;
            GuardcrossbownightColonist = 0;
            GuardmatchlocknightColonist = 0;
            MinerjobColonist = 0;
            ForesterColonist = 0;
            FlaxfarmerColonist = 0;
            AlkanetfarmerColonist = 0;
            HollyhockfarmerColonist = 0;
            WolfsbanefarmColonist = 0;
            WheatfarmerColonist = 0;
            DyerColonist = 0;
            StonemasonColonist = 0;
            GunsmithjobColonist = 0;
            MerchantColonist = 0;
            MinterColonist = 0;
            TailorColonist = 0;
            TechnologistColonist = 0;
            KilnjobColonist = 0;
            FineryforgejobColonist = 0;
            WoodcutterColonist = 0;
            BloomeryjobColonist = 0;
            MetalsmithjobColonist = 0;
            SmelterColonist = 0;
            BakerColonist = 0;
            GrinderColonist = 0;
            ScientistColonist = 0;
            CrafterColonist = 0;

            // 再表示
            DisplayColonistInformation();
        }
    }
}
