window.scrollHandler = {
    checkIfScrolledToEnd: function (element) {
        if (!element) return false;
        return element.scrollHeight - element.scrollTop <= element.clientHeight + 100;
    }
};