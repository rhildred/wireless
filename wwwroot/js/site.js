// Write your Javascript code.
$(".messages").animate({ scrollTop: $(document).height() }, "fast");
var sFrom = "you@" + Math.ceil(Math.random() * 1000);
$("#uName").html(sFrom);
function newMessage() {
	message = $(".message-input input").val();
	if($.trim(message) == '') {
		return false;
	}
	$('<li class="sent"><img src="images/Y.svg" alt="" /><p>' + message + '</p></li>').appendTo($('.messages ul'));
    $.post("/", "From=" + encodeURIComponent(sFrom) +
                        "&Body=" + encodeURIComponent(message), (data)=>{
            console.log(data);
            $('<li class="replies"><img src="images/B.svg" alt="" /><p>' + $(data).find("Message").html() + '</p></li>').appendTo($('.messages ul'));
    });
	$('.message-input input').val(null);
	$('.contact.active .preview').html('<span>You: </span>' + message);
	$(".messages").animate({ scrollTop: $(document).height() }, "fast");
};
$('.submit').click(function() {
  newMessage();
});
$(window).on('keydown', function(e) {
  if (e.which == 13) {
    newMessage();
    return false;
  }
});