function displayTooltip(element) {
    $(element).tooltip();
    console.log("tool tip added");
};
Blazor.registerFunction("displayTooltip", displayTooltip);
