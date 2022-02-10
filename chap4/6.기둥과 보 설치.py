# n은 벽면의 크기, build_frame 은 작업이 순서대로 담기 2차원 배열
def impossible(result): # (x, y, r) => r이 0이면 기둥, r이 1이면 보
    for x, y, r in result:
        if r == 0:
            if y != 0 and (x, y-1, 0) not in result and (x-1, y, 1) \
                    not in result and (x, y, 1) not in result:
                return True
        else:
            if (x, y-1, 0) not in result and (x+1, y-1, 0) not in result \
                    and not ((x-1, y, 1) in result and (x+1, y, 1) not in result):
                return True
    return False
def solution(n, buil_frame):
    result = []
    for x, y, a, b in buil_frame:
        if b == 1:
            result.add([x, y, a, b])
            if impossible(result):
                result.remove([x, y, a, b])
        elif [x, y, a] in result:
            if impossible(result):
                result.add([x, y, a, b])
    return result.sort(key=lambda x: (x[0], x[1], x[2]))


    