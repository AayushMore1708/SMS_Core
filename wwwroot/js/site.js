// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Ensure the DOM is fully loaded before binding events
document.addEventListener('DOMContentLoaded', function () {
    const toastTrigger = document.getElementById('liveToastBtn'); // Button that triggers the toast
    const liveToast = document.getElementById('liveToast'); // Toast element

    if (toastTrigger) {
        toastTrigger.addEventListener('click', function () {
            const toast = new bootstrap.Toast(liveToast); // Initialize the toast
            toast.show(); // Show the toast
        });
    }
});
