/// <reference path="file1.d.ts" />
Blazor.registerFunction('doPrompt', function (message) {
    return prompt(message);
});

