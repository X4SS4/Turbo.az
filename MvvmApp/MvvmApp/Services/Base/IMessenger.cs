namespace TurboAz.Services.Base;

using TurboAz.Models.Messages.Base;
using System;

public interface IMessenger {
    void Send<TKey>(TKey arg) where TKey : IMessage;
    void Subscribe<TKey>(Action<IMessage> action) where TKey : IMessage;
}