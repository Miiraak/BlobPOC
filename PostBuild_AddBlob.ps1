param([string]$exePath)

# Exemple de donn�es � ajouter
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

# Concat�ner
$newBytes = New-Object byte[] ($bytes.Length + $blobBytes.Length)
[Array]::Copy($bytes, 0, $newBytes, 0, $bytes.Length)
[Array]::Copy($blobBytes, 0, $newBytes, $bytes.Length, $blobBytes.Length)

# �crire � nouveau (�crase, mais avec tout le contenu original + blob � la fin)
[System.IO.File]::WriteAllBytes($exePath, $newBytes)

Write-Host "Blob ajout� avec succ�s � la fin de l'ex�cutable."
