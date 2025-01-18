// JavaScript function to trigger a download of the file
function downloadFile(filename, base64Data) {
    var link = document.createElement('a');
    link.href = 'data:application/pdf;base64,' + base64Data;
    link.download = filename;
    link.click();
}
