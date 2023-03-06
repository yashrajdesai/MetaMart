mergeInto(LibraryManager.library, {

  GetJSON: function (path, objectName, callback, fallback) {
    var parsePath= Pointer_stringify(path);
    var parseObjectName = Pointer_stringify(objectName);
    var parseCallback = Pointer_stringify(callback);
    var parseFallback = Pointer_stringify(fallback);

    try {

      firebase.database().ref(parsePath).once('value').then(function(snapshot){
          myGameInstance.SendMessage(parseObjectName, parseCallback, JJSON.stringify(snapshot_val()));
      });
    
    }catch(error){
      myGameInstance.SendMessage(parseObjectName, parseFallback, "There was an error: " +  error.message);
    }

  },

});