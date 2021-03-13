<template>
    <div class="customer-header-button">
        <button class="content-feature">
            <div class="icon-add"><img src="../../assets/icon/add.png" alt=""></div>
            <div class="btn-text">Thêm mới</div>
            <div class="icon-down"><i class="fa fa-chevron-down" aria-hidden="true"></i></div>
        </button>
    </div>
</template>

<script>
export default {
    
}
</script>

<style scoped>
.content-feature{
        position: absolute;
        right: 16px;
        display: flex;
        height: 40px;
        background-color: #019160;
        border-radius: 4px;
        cursor: pointer;
        border: none;
        outline: none;
        margin-top: -10px;
    }
    .icon-add{
        width: 16px;
        height: 16px;
        line-height: 40px;
        margin-left: 5px;
        cursor: pointer;
    }
    .icon-add img{
        margin-top: 10px;
    }
    .btn-text{  
        margin: 0px 10px;
        line-height: 40px;
        font-size: 13px;
        border-right: 1px solid white;
        padding:0px 16px ;
    }
    .icon-down{
        line-height: 40px;
        margin-right: 12px;
    }
</style>