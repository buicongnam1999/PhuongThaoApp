<template>
    <div class="login-form">
        <div class="login-form-content">
            <form action="">
                <div class="account">
                    <label for="">Tài khoản</label>
                    <div class="form-input">
                        <input type="text" name="" id="" placeholder="Email" v-model="customer.account">
                    </div>
                    <label for="">{{MessageAccount}}</label>
                </div>
                <div class="password">
                    <label for="">Mật khẩu</label>
                    <div class="form-input">
                        <input type="password" name="" id="" placeholder="Password" v-model="customer.pass">
                    </div>
                    <label for="">{{MessagePass}}</label>
                </div>
                <div class="forgot-pass">
                    Quên tài khoản?
                </div>
                <div class="btn-login" @click="Login">
                    Đăng nhập
                </div>
            </form>
            <div class="register">
                Chưa có tài khoản?
                <router-link to="register">Tạo tài khoản</router-link>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    data() {
        return {
            MessageAccount: '',
            MessagePass: '',
            customer:{
                account: '',
                pass: ''
            }
        }
    },
    methods: {
        Login: function(){
            if(this.customer.account === ''){
                this.MessageAccount = 'Tài khoản để trống'
            }else{
                this.MessageAccount = ''
            }
            if(this.customer.pass === ''){
                this.MessagePass = 'Mật khẩu không được phép để trống'
            }else{
                this.MessagePass = ''
            }
        }
    },
}
</script>
<style scoped>
.login-form{
    background: white none repeat scroll 0 0;
    -webkit-box-shadow: 2px 2px 11px 0 rgb(0 0 0 / 10%);
    box-shadow: 2px 2px 11px 0 rgb(0 0 0 / 10%);
    padding: 30px 30px 20px;
    width: 570px;
    margin: 50px auto;
    height: 300px;
}
.account, .password{
    display: flex;
}
.account label, .password label{
    font-family: inherit;
    width: 100px;
    height: 30px;
    line-height: 30px;
    opacity: 0.8;
}
.password,.account{
    margin-top: 20px;
    padding-left: 0px;
}
.form-input input{
    /* border: none;
    outline: none; */
    padding-left: 20px;
    background: #ebebeb none repeat scroll 0 0;
    border: 1px solid #ebebeb;
    width: 300px;
    height: 30px;
    font-size: 15px;
    outline: none;
}
.forgot-pass{
    margin: 20px calc(35%);
    cursor: pointer;
}
.forgot-pass:hover{
    color: red;
    opacity: 0.8;
}
.btn-login{
    cursor: pointer;
    width: 97px;
    height: 30px;
    line-height: 30px;
    background: #333 none repeat scroll 0 0;
    color: white;
    font-weight: 600;
    padding: 0 18px;
    text-transform: uppercase;
    font-family: 'Libre Franklin', sans-serif;
    margin: 0 calc(34%);
}
.register{
    width: 630px;
    padding: 25px calc(30%);
    width: 90%;
    border-top: 1px solid #e5e5ee;
    margin: 25px auto;
    font-size: 15px;
}
.register a{
    list-style: none;
    text-decoration: none;
}
</style>