
$(document).ready(function () {

    

    
        $(".retrieveEmpId").change(function () {

            
            $.ajax({
                url: "/Admin/Transaction/FilteredTransactions?EmpId=" + $(this).val(),
                type: "GET",

                success: function (data) {
                    //alert(data);

                    var table = $("#stopTransactions tbody");
                    var employeeId = 0;
                    table.empty();
                    $.each(data.data, function (i, item) {
                        table.append(`<tr><td>` + item.id + `</td><td class="align-middle">` + item.payrollCode.payName + `</td><td class="align - middle">` + item.payrollCode.paycodeType + `</td><td class="align - middle">` + item.transYear + `</td><td class="align - middle">` + item.startPeriod + `</td><td class="align - middle">` + item.dispTransAmount + "</td>" +
                            `<td class="fs--1 align-middle">
                                                    <input class="form-check-input" id = "${item.id}" value="${item.id}" name="chkBox" type="checkbox" data-bulk-select-row="{&quot;name&quot;:&quot;Anna&quot;,&quot;email&quot;:&quot;anna@example.com&quot;,&quot;age&quot;:18}" />
                                                </td>`
                            + "</tr>");
                        employeeId = item.employeeId;
                        //alert(item.id);
                    });
                  
                    $("#mytotal").empty();
                    $("#mytotal").append(data.totalamount);
                    $(".retrieveTrans").empty();
                    $("#SelectedId").val(employeeId);
                }

            });
        });


          // add multiple select / deselect functionality
     $("#bulk-select-example").click(function () {
        $('.form-check-input').attr('checked', this.checked);
        //alert('I am here');
    });


    // if all checkbox are selected, check the selectall checkbox     // and viceversa
    $(".form-check-input").click(function () {
        if ($(".form-check-input").length == $(".form-check-input:checked").length) {
            $("#bulk-select-example").attr("checked", "checked");
        }
        else {
            $("#bulk-select-example").removeAttr("checked");
        }
    });

   

    //Post Data

    document.getElementById('btnpostdata').addEventListener('click', 
    function(event) { 
        event.preventDefault();       
        debugger
        let ids = [];
        var table = $('#stopTransactions').DataTable();
        if ($('[name="chkBox"]:checked').length <= 0) {
            alert('Please select minimum one data');
            exit();
        }
        else {
          
            $('[name="chkBox"]:checked').each(function (data) {
                ids.push($(this).val());          
             });
            
             $.ajax({
                url: '/Admin/Transaction/StopTransaction',
                type: 'POST',              
                dataType: 'json',               
                data: JSON.stringify(ids),
                contentType: 'application/json; charset=utf-8',       
                 success: function (data) {              
                    console.log("Success: ", data);
                 },
                 error: function (e) {
                     console.log('--error--')
                     
                 }
             }); 
 
        }
      });

});
    


