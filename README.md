This exemple use BlobPE 1.1.0.
It's still functional with the new 1.1.2 version.

# Index :
BlobPE initialization -> [Program.cs](https://github.com/Miiraak/BlobPOC/blob/88bdbdb995f66c7204c76438c2abbf7b187f6e64/BlobPOC/Program.cs#L12) <br>
BlobPE Usages -> [MainForm.cs](https://github.com/Miiraak/BlobPOC/blob/88bdbdb995f66c7204c76438c2abbf7b187f6e64/BlobPOC/MainForm.cs)

## Usage
| Method | Description |
|--- | --- |
| [**CheckForUpdates(string[] args, Dictionary<string, int> defaultData)**](https://github.com/Miiraak/BlobPOC/blob/88bdbdb995f66c7204c76438c2abbf7b187f6e64/BlobPOC/Program.cs#L12C13-L12C83) | Checks for update args and applies updates if specified. defaultData is used when no blob is found in the binaries, using the string for key name and int for maximalData size. |
| [**RemoveUpdateFiles()**](https://github.com/Miiraak/BlobPOC/blob/88bdbdb995f66c7204c76438c2abbf7b187f6e64/BlobPOC/MainForm.cs#L14) | Removes any update files created during the update process. |
| [**Get(string key)**](https://github.com/Miiraak/BlobPOC/blob/88bdbdb995f66c7204c76438c2abbf7b187f6e64/BlobPOC/MainForm.cs#L23) | Retrieves a value as a string from the blob data by its key. |
| [**GetBool(string key)**](https://github.com/Miiraak/BlobPOC/blob/88bdbdb995f66c7204c76438c2abbf7b187f6e64/BlobPOC/MainForm.cs#L26) | Retrieves a value as boolean from the blob data by its key. |
| [**GetInt(string key)**](https://github.com/Miiraak/BlobPOC/blob/88bdbdb995f66c7204c76438c2abbf7b187f6e64/BlobPOC/MainForm.cs#L25) | Retrieves a value as integer from the blob data by its key. |
| [**Set(string key, object value)**](https://github.com/Miiraak/BlobPOC/blob/88bdbdb995f66c7204c76438c2abbf7b187f6e64/BlobPOC/MainForm.cs#L44) | Sets the value for a specified key in the blob data. |
| [**Save()**](https://github.com/Miiraak/BlobPOC/blob/88bdbdb995f66c7204c76438c2abbf7b187f6e64/BlobPOC/MainForm.cs#L47) | Saves the current state of the app data back into his own executable file. |
| [**Reset()**](https://github.com/Miiraak/BlobPOC/blob/88bdbdb995f66c7204c76438c2abbf7b187f6e64/BlobPOC/MainForm.cs#L56) | Clears the blob data, removing all value, keeping the key and size value. |
| [**Delete()**](https://github.com/Miiraak/BlobPOC/blob/88bdbdb995f66c7204c76438c2abbf7b187f6e64/BlobPOC/MainForm.cs#L61) | Deletes the blob data from the executable file, removing all traces of the stored data. |
