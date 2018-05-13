using Branding.Core;

namespace Branding.ViewModels {

    public class TypeSystemViewModel : ViewModelBase {

        public TypeSystemViewModel(BlackTypeScaleViewModel blackTypeScale, WhiteTypeScaleViewModel whiteTypeScale1) {
            BlackTypeScale = blackTypeScale;
            WhiteTypeScale = whiteTypeScale1;
        }


        public BlackTypeScaleViewModel BlackTypeScale { get; }
        public WhiteTypeScaleViewModel WhiteTypeScale { get; }
    }
}