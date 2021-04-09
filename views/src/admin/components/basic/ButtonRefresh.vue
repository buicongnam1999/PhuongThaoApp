<template>
    <div class="refresh">
        <div class="btn-refresh">
            <img src="../../../assets/icon/refresh.png" alt="" srcset="">
        </div>
    </div>
</template>
<script>
export default {
    data() {
        return {
            
        }
    },
}
</script>

<style scoped>
.refresh{
    width: 10%;
    justify-content: flex-end;
}
.btn-refresh{
    justify-content: flex-end;
    padding: 0px 15px;
    background-color: #fff;
    border: 1px solid #bbbbbb;
    height: 40px;
    line-height: 48px;
    border-radius: 4px;
    position: relative;
    width: 18px;
    float: right;
    margin-right: 16px;
    cursor: pointer;
}
</style>