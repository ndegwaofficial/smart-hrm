var dataTable;
$(document).ready(function () {

    $('form', dialog).submit(function () {
        var formData = new FormData($(this)[0]);
        $.ajax({
            url: this.action,
            type: this.method,
            contentType: this.enctype,
            data: formData,
            success: function (result) {
                if (result.success) {
                    $('#myModal').modal('hide');
                    $('#replacetarget').load(result.url); //  Load data from the server and place the returned HTML into the matched element
                } else {
                    $('#myModalContent').html(result);
                    bindForm(dialog);
                }
            }
        });
        return false;
    });
    
});



function Delete(url, title) {
    Swal.fire({
        title: 'Are you sure to Delete this ' + title + '?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    if (data.success) {
                        location.reload(true);
                        toastr.success(data.message);
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}

