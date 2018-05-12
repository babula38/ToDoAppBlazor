interface BlazorHelpers {
    registerFunction(name: string, fun: Function);
    Platform: Platform;
}

interface Platform {
    findMethod();
}
declare var Blazor: BlazorHelpers;