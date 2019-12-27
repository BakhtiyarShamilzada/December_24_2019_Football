$(document).ready(function () {

    $(document).on('click', '#DeleteFootballPlayer', function (e) {
        var FootballPlayerId = $(this).prev().val();
        e.preventDefault();
        swal({
            title: "Are you sure ?",
            text: "Once deleted, you will not be able to recover this !",
            icon: "warning",
            buttons: true,
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {
                    $.ajax(
                        {
                            url: "/Ajax/DeleteByFootballPlayerId?FootballPlayerId=" + FootballPlayerId,
                            type: "POST",
                            success: function (res) {
                                $("table").fadeIn();
                                $("tbody").html(res);
                                swal("Deleted !", {
                                    icon: "success",
                                });
                            },
                            error: function () {
                                swal("An error occurred !", {
                                    icon: "error",
                                });
                            }
                        });

                } else {
                    swal("This is safe !");
                }
            });
    })

    $(document).on('click', '#DeleteFootballCart', function (e) {
        var FootballCartId = $(this).prev().val();
        e.preventDefault();
        swal({
            title: "Are you sure ?",
            text: "Once deleted, you will not be able to recover this !",
            icon: "warning",
            buttons: true,
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {
                    $.ajax(
                        {
                            url: "/Ajax/DeleteByFootballCartId?FootballCartId=" + FootballCartId,
                            type: "POST",
                            success: function (res) {
                                $("table").fadeIn();
                                $("tbody").html(res);
                                swal("Deleted !", {
                                    icon: "success",
                                });
                            },
                            error: function () {
                                swal("An error occurred !", {
                                    icon: "error",
                                });
                            }
                        });

                } else {
                    swal("This is safe !");
                }
            });
    })

    $(document).on('change', '#input-date', function () {
        console.log($(this).val())
    })

    $(document).on('click', '#search', function () {
        let date1 = $('#date-1').val();
        let date2 = $('#date-2').val();
        let positionId = $('#position').val();
        let cartId = $('#cart').val();
        console.log(date1)
        console.log(date2)
        console.log(positionId)
        console.log(cartId)
        $.ajax(
            {
                url: "/Ajax/FilterFootballCart?date1=" + date1 + "&date2=" + date2 + "&positionId=" + positionId + "&cartId=" + cartId,
                type: "POST",
                success: function (res) {
                    $("table").fadeIn();
                    $("tbody").html(res);
                },
                error: function () {
                    swal("An error occurred !", {
                        icon: "error",
                    });
                }
            });
    })

    $('.football-players-id').each(function () {
        if ($(this).prop('checked') == true) {
            let footballPlayerId = $(this).attr('data-football-players-id');
            $('#FootballPlayersId').val($('#FootballPlayersId').val() + footballPlayerId + ",");
        }
    })
    

    $(document).on('click', '.football-players-id', function () {
        let footballPlayerId = $(this).attr('data-football-players-id');
        if ($(this).prop('checked') == true) {
            $('#FootballPlayersId').val($('#FootballPlayersId').val() + footballPlayerId + ",");
        }
        else {
            let arr = $('#FootballPlayersId').val().split(',');
            arr = arr.filter(el => el != footballPlayerId);
            $('#FootballPlayersId').val(arr.join(','));
        }
        
    })

})