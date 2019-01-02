## ArgumentException In AddModulesAsync()
**This is a minor exception caused mainly when updating from Discord.Net 1.0.9 to Discord.Net 2.0**

```cs
//Previous way of doing it
await commands.AddModulesAsync(Assembly.GetEntryAssembly());

//New way of doing it (No Dependency Injection)
await commands.AddModulesAsync(Assembly.GetEntryAssembly(), null);

//New way of doing it (With Dependency Injection)
await commands.AddModulesAsync(Assembly.GetEntryAssembly(), ServiceCollection);
```

This new way of handling adding your Modules to the CommandService is primarily to allow for Dependency Injection [Read Up On It Here](https://docs.stillu.cc/guides/commands/dependency-injection.html). If you're not using DI at all then simply passing null is fine. (As Shown above)

Discord:  [Discord-BOT-Tutorial Server](https://discord.gg/cGhEZuk)