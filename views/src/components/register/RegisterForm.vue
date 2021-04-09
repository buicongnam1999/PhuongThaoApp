<template>
    <div class="register-form">
        <div class="register-form-content">
            <div class="title">
                <div class="title-header">
                    Bạn đã có tài khoản chưa?
                </div>
                <div class="title-register">
                    <router-link to="login">Đăng nhập</router-link>
                </div>
            </div>
            <form action="">
                <div class="account">
                    <label for="">Tài khoản</label>
                    <div class="form-input">
                        <input type="text" name="" id="" placeholder="Tài khoản">
                    </div>
                    <label for="">{{MessageAccount}}</label>
                </div>
                <div class="password">
                    <label for="">Mật khẩu</label>
                    <div class="form-input">
                        <input type="password" name="" id="" placeholder="Mật khẩu">
                    </div>
                    <label for="">{{MessagePass}}</label>
                </div>
                <div class="account">
                    <label for="">Họ và tên</label>
                    <div class="form-input">
                        <input type="text" name="" id="" placeholder="Họ và tên">
                    </div>
                    <label for="">{{MessageAccount}}</label>
                </div>
                <div class="gender">
                    <label for="">Giới tính</label>
                    <input type="radio" name="" id="" value="1"><span style="margin-left: 3px; margin-right: 10px">Nam</span>
                    <input type="radio" name="" id="" value="2"><span style="margin-left: 3px">Nữ</span>
                </div>
                <div class="password">
                    <label for="">Số điện thoại</label>
                    <div class="form-input">
                        <input type="password" name="" id="" placeholder="Số điện thoại">
                    </div>
                    <label for="">{{MessagePass}}</label>
                </div>
                <div class="account">
                    <label for="">Địa chỉ</label>
                    <div class="form-input">
                        <input type="text" name="" id="" placeholder="Địa chỉ">
                    </div>
                    <label for="">{{MessageAccount}}</label>
                </div>
                <div class="password">
                    <label for="">Email</label>
                    <div class="form-input">
                        <input type="password" name="" id="" placeholder="Email">
                    </div>
                    <label for="">{{MessagePass}}</label>
                </div>
                <div class="btn-register">
                    Đăng ký
                </div>
            </form>
        </div>
    </div>
</template>

<script>
export default {
    data() {
        return {
            User:{
                
            }
        }
    },
}
</script>
<style scoped>
.title{
    display: flex;
    font-size: 18px;
}
.title-header{

}
.title-register{
    margin-left: 10px;
}
.register-form{
    background: white none repeat scroll 0 0;
    -webkit-box-shadow: 2px 2px 11px 0 rgb(0 0 0 / 10%);
    box-shadow: 2px 2px 11px 0 rgb(0 0 0 / 10%);
    padding: 30px 30px 20px;
    width: 970px;
    margin: 50px auto;
    height: 610px;
}
.account, .password,.gender{
    display: flex;
    margin-top: 20px;
    padding-left: 80px;
}
.account label, .password label, .gender label{
    font-family: inherit;
    width: 100px;
    height: 30px;
    line-height: 30px;
    opacity: 0.8;
}
.form-input input{
    /* border: none;
    outline: none; */
    padding-left: 20px;
    background: #ebebeb none repeat scroll 0 0;
    border: 1px solid #ebebeb;
    width: 400px;
    height: 30px;
    font-size: 15px;
    outline: none;
}
.gender{
    line-height: 30px;
}
.gender input[type="radio"]{
    margin-top: 8px;
}
.btn-register{
    cursor: pointer;
    width: 75px;
    height: 30px;
    line-height: 30px;
    background: #333 none repeat scroll 0 0;
    color: white;
    font-weight: 600;
    padding: 0 18px;
    text-transform: uppercase;
    font-family: 'Libre Franklin', sans-serif;
    margin: 20px calc(40%);

}
</style>