using DesignPatterns.Memento;
var draft = new TransferDraft();
var history = new DraftHistory();
draft.Set("ACC-1001", 10000m, "Rent");
history.Save(draft.CreateMemento());
draft.Set("Wrong Account", 50000m, "Changed by mistake");
draft.Restore(history.Undo());
draft.Print();
