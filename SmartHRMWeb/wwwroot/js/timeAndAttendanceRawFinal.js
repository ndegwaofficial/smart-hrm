var dataTable;
$(document).ready(function () {
    loadDataTable();
    $("#checkedAll").change(function () {
        if (this.checked) {
            $(".checkSingle").each(function () {
                this.checked = true;
            });
        } else {
            $(".checkSingle").each(function () {
                this.checked = false;
            });
        }
    });

    $(".checkSingle").click(function () {
        if ($(this).is(":checked")) {
            var isAllChecked = 0;

            $(".checkSingle").each(function () {
                if (!this.checked)
                    isAllChecked = 1;
            });

            if (isAllChecked == 0) {
                $("#checkedAll").prop("checked", true);
            }
        }
        else {
            $("#checkedAll").prop("checked", false);
        }
    });

   
    //Post Data

    document.getElementById('btnpostdata').addEventListener('click',
        function (event) {
            event.preventDefault();
            //debugger
            var timeattendanceData = [];
            var table = $('#timeAttendanceRawtblbody').DataTable();
            if ($('[name="chkBox"]:checked').length <= 0) {
                alert('Please select minimum one data');
                exit();
            }
            else {

                $('[name="chkBox"]:checked').each(function (data) {
                    var row = $(this).closest("tr"); 
                    
                    var data = $('#timeAttendanceRawtblbody').DataTable().row(row).data();
                   
                    timeattendanceData.push({
                        "Id": data['id'],
                        "EmpId": data['employeeId'],
                        "ContractTypeId": data.employee['contractTypeId'],
                        "PresentDays": parseFloat(data['presentDays']).toFixed(2),
                        "AbsentDays": parseFloat(data['absentDays']).toFixed(2),
                        "Period": data['period'],
                        "Cyear": data['cyear'],
                        "Posted": false,
                    });


                });

                var dataToPost = JSON.stringify({ timeattendanceData });
                //var dataToPost = JSON.stringify(model);


                $.ajax({
                    type: "post",
                    dataType: "json",
                    url: '/Admin/TimeAttendanceRaw/PostTimeAttendance',
                    data: JSON.stringify(timeattendanceData),
                    contentType: "application/json; charset=utf-8",
                    traditional: true,
                    success: function (data) {

                        if (data.success === true) {
                            location.reload({ forceReload: true });
                        }
                        //location.reload({ forceReload: true }); // reload the page
                    },
                    error: function (e) {
                        console.log('--error--');

                    }
                });

            }
        });
    


});

function loadDataTable() {
   
    dataTable = $('#timeAttendanceRawtblbody').DataTable({
        "ajax": {
            "url": "/Admin/TimeAttendanceRaw/GetAll"
        },                

        "columns": [               
            { "data": "id", "width": "5%", "sClass": "align-middle" },           
            { "data": "employee.fullNameWithCode", "width": "15%", "sClass": "align-middle" },
            { "data": "period", "width": "5%", "sClass": "align-middle" },
            { "data": "cyear", "width": "5%", "sClass": "align-middle" },
            { "data": "presentDays", "width": "5%", "sClass": "align-middle" },
            { "data": "absentDays", "width": "5%", "sClass": "align-middle" },   
            
            {
                "data": "employeeId",
                "render": function (data) {
                    return `<input class="form-check-input checkSingle" id = "${data}" value="${data}" name="chkBox" type="checkbox" data-bulk-select-row="{&quot;name&quot;:&quot;Anna&quot;,&quot;email&quot;:&quot;anna@example.com&quot;,&quot;age&quot;:18}" />`
                },
                "width": "5%",
            },
        ]
    });

}

function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
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
                        dataTable.ajax.reload();
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








