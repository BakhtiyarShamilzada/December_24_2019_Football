$(document).ready(function () {

    // Select initial date from `eventDates`
    $picker = $('.datepicker-here').each(function () {
        var currentDate = currentDate = new Date();
        $(this).data('datepicker').selectDate(new Date(currentDate.getFullYear(), currentDate.getMonth(), currentDate.getDate()));
    })

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

    $(document).on('click', '#DeleteGameTime', function (e) {
        var GameTimeId = $(this).prev().val();
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
                            url: "/Ajax/DeleteByGameTimeId?GameTimeId=" + GameTimeId,
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

    $(document).on('click', '#DeleteStadium', function (e) {
        var StadiumId = $(this).prev().val();
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
                            url: "/Ajax/DeleteByStadiumId?StadiumId=" + StadiumId,
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
    
    $(document).on('change', '#CreatePhoto', function (e) {
        if ($(this).val() != "") {
            if ([...e.target.files][0].type.match("image/*")) {
                let reader = new FileReader();
                reader.onloadend = function (read) {
                    $('#CurrentImageArea').fadeIn();
                    $('#CurrentImage').attr('src', read.target.result);
                }
                reader.readAsDataURL([...e.target.files][0]);
            }
        }
    })

    $(document).on('change', '#football-player', function () {
        var footballPlayerId = $(this).val();
        if (footballPlayerId) {
            $.ajax(
                {
                    url: "/Ajax/LoadSelectGameTimesByFootballPlayerId?FootballPlayerId=" + footballPlayerId,
                    type: "POST",
                    success: function (res) {
                        $("#game-time").html(res).prepend("<option disabled selected >Choose</option>");
                    },
                    error: function () {
                        swal("Xəta baş verdi !", {
                            icon: "error",
                        });
                    }
                })
        }
    })

})