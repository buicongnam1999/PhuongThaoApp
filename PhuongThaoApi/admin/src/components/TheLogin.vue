<template>
    <div :class="{isHide: isHide}">
        <div class="login">
            <div class="login-header">
                <div class="wrapper">
                    <div class="container">
                        <h1>Welcome</h1>
                    </div>
                </div>
                <div class="container">
                    <form class="form">
                        <input type="text" placeholder="Username">
                        <input type="password" placeholder="Password">
                        <div class="button" @click="Check" id="login-button">Login</div>
                    </form>
                </div>
            </div>
        </div>
        
    </div>
</template>

<script>
export default {
    data() {
        return {
            
        }
    },
    props:{
        isHide: Boolean
    },
    methods: {
        Check: function() {
            this.$emit('CloseForm')
        }
    },
    
}
</script>

<style scoped>
.isHide{
    display: none;
}
.wrapper{
    background: #50a3a2;
    background: -webkit-linear-gradient(top left, #50a3a2 0%, #53e3a6 100%);
    background: -moz-linear-gradient(top left, #50a3a2 0%, #53e3a6 100%);
    background: -o-linear-gradient(top left, #50a3a2 0%, #53e3a6 100%);
    background: linear-gradient(to bottom right, #50a3a2 0%, #53e3a6 100%);
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 830px;
    margin-top: -200px;
    overflow: hidden;
    z-index: 1;
}
.container{
    max-width: 600px;
	margin: 0 auto;
	padding: 80px 0;
	height: 400px;
	text-align: center;
}
h1{
    font-size: 40px;
    transition-duration: 1s;
    transition-timing-function: ease-in-put;
    font-weight: 200;
    z-index: 9999;
    margin-top: 250px;
}
.form{
    padding: 20px 0;
	position: relative;
    top: -370px;
	z-index: 2;
}
input{
    display: block;
    appearance: none;
    outline: 0;
    border: 2px solid #e5e5e5;
    background-color: fade(white, 20%);
    width: 250px;
    border-radius: 3px;
    padding: 10px 15px;
    margin: 0 auto 10px auto;
    display: block;
    text-align: center;
    font-size: 18px;
    cursor: pointer;
    transition-duration: 0.25s;
    font-weight: 300;
}
input:hover{
    background-color: fade(white, 40%);
}
input:focus{
    background: white;
    width: 300px;
    color: black;
    opacity: 0.6;
    border: 2px solid #e5e5e5;
}
.button{
    appearance: none;
    outline: 0;
    background-color: white;
    border: 0;
    padding: 10px 15px;
    color: black;
    border-radius: 3px;
    width: 255px;
    cursor: pointer;
    font-size: 18px;
    transition-duration: 0.25s;
    margin: 0 auto;
}
.button:hover{
    background-color: rgb(245, 247, 249);
}
</style>