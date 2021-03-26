<template>
    <div>
        <div class="login">
            <div class="login-header">
                <div class="wrapper">
                    <div class="container">
                        <h1>Phuong Thao Shop</h1>
                        <h2>Welcome</h2>
                    </div>
                </div>
                <div class="container">
                    <form class="form">
                        <label for="" style="position: relative"><i>{{message}}</i></label>
                        <input type="text" placeholder="Username" v-model="account.name">
                        <label for="" style="position: relative"><i>{{messageName}}</i></label>
                        <input type="password" placeholder="Password" v-model="account.pass">
                        <label for="" style="position: relative"><i>{{messagePass}}</i></label>
                        <div class="button" @click.prevent="Check" id="login-button">Login</div>
                    </form>
                </div>
            </div>
        </div>
        
    </div>
</template>

<script>
import axios from 'axios'
export default {
    data() {
        return {
            account:{
                name: '',
                pass: ''
            },
            messageName: '',
            messagePass: '' ,
            user:{
                "u_id": 0,
                "user_fullname": 'a',
                "user_gender": -1,
                "user_phone": '',
                "user_email": '',
                "user_address": '',
                "u_name": '',
                "user_pass": '',
                "user_type": 1,
                "user_status": 1,
                "user_img": ''
            },
            message: '',
            status: true
        }
    },
    props:{
        isHide: Boolean
    },
    methods: {
        async Check() {
            if(this.account.name == ''){
                this.messageName = 'Tài khoản không được để trống'
            }else{
                this.messageName = ''
            }
            if(this.account.pass == ''){
                this.messagePass = 'Mật khẩu không được để trống'
            }else{
                this.messagePass = ''
            }
            if(this.checkValidate){
                await axios.get("https://localhost:44344/api/user/"+this.account.name+"&&"+this.account.pass)
                .then(res => this.user = res.data)
                if(this.user.length != 0 ){
                    this.$router.push({path: '/'})
                }else{
                    this.message = 'Tài khoản không tồn tại.'
                }
                console.log(this.user.user_fullname)
                
            }

            
        },
        Validate(){
            if(this.account.name == ''){
                this.messageName = 'Tài khoản không được để trống'
            }else{
                this.messageName = ''
            }
            if(this.account.pass == ''){
                this.messagePass = 'Mật khẩu không được để trống'
            }else{
                this.messagePass = ''
            }
        }
    },
    computed:{
        checkValidate(){
            
            if(this.account.name == '' || this.account.pass == ''){
                return false
            }else{
                return true
            }
        }
    }
    
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
h2{
    font-size: 30px;
    transition-duration: 1s;
    transition-timing-function: ease-in-put;
    font-weight: 200;
    z-index: 9999;
    margin-top: -20px;
    color: white;
    opacity: 0.6;
}
.form{
    padding: 20px 0;
	position: relative;
    top: 60px;
    right: 120px;
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