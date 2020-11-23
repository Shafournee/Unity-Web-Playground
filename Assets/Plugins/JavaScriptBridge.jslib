mergeInto(LibraryManager.library, {

	SetBackgroundColor: function(message) {
		window.document.body.style.backgroundColor = Pointer_stringify(message);
	},
	
	CloseWindow: function() {
		window.close();
	},
});