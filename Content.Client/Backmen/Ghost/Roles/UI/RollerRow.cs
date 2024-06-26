﻿using Content.Shared.Backmen.Ghost.Roles.Components;
using Content.Shared.Backmen.Reinforcement;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Backmen.Ghost.Roles.UI;

[GenerateTypedNameReferences]
public sealed partial class RollerRow : PanelContainer
{
    public Entity<GhostVisRollerComponent> Entity;
    public RollerRow()
    {
        RobustXamlLoader.Load(this);
    }
}
