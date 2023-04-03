using Content.Shared.Containers.ItemSlots;
using Content.Shared.Botany;
using Robust.Client.GameObjects;
using Robust.Client.UserInterface.Controls;
using Robust.Shared.Prototypes;

namespace Content.Client.Botany.UI
{
    public sealed class SeedAnalyzerBoundUserInterface : BoundUserInterface
    {
        [Dependency] private readonly IEntityManager _entityManager = default!;
        [Dependency] private readonly IPrototypeManager _prototypeManager = default!;

        private SeedAnalyzerWindow? _window;

        public SeedAnalyzerBoundUserInterface(ClientUserInterfaceComponent owner, Enum uiKey) : base(owner, uiKey) { }

        protected override void Open()
        {
            base.Open();

            _window = new SeedAnalyzerWindow(this, _entityManager, _prototypeManager);
            _window.OpenCentered();
            _window.OnClose += Close;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (!disposing)
            {
                return;
            }

            _window?.Dispose();
        }

    }
}
