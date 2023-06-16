namespace TurboAz.Models.Messages;

using TurboAz.Models.Messages.Base;
using System;

public class NavigationMessage : IMessage {
    public NavigationMessage(Type destinationViewModelType) {
        DestinationViewModelType = destinationViewModelType;
    }

    public Type DestinationViewModelType { get; set; }
}