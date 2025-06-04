param([string]$exePath)

# Exemple de données à ajouter
$data = @{
    lang = "_____"
    ext  = "_____"
    autolog = "_____"
}

# Format JSON et balises
$blob = '[BLOB_START]' + (ConvertTo-Json $data -Compress) + '[BLOB_END]'
$blobBytes = [System.Text.Encoding]::UTF8.GetBytes($blob)

# Lire le fichier binaire original
$bytes = [System.IO.File]::ReadAllBytes($exePath)

# Concaténer
$newBytes = New-Object byte[] ($bytes.Length + $blobBytes.Length)
[Array]::Copy($bytes, 0, $newBytes, 0, $bytes.Length)
[Array]::Copy($blobBytes, 0, $newBytes, $bytes.Length, $blobBytes.Length)

# Écrire à nouveau (écrase, mais avec tout le contenu original + blob à la fin)
[System.IO.File]::WriteAllBytes($exePath, $newBytes)

Write-Host "Blob ajouté avec succès à la fin de l'exécutable."
